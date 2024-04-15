using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace WinFormsApp1
{
    public partial class Form3 : Form
    {
        OleDbConnection connection = new OleDbConnection();
        public string TableName = "員工工令主表";
        public bool IsFindOrder = false;
        public Form3()
        {
            InitializeComponent();

            NameLabel.Text = MainTableField.EmplyeeID + MainTableField.EmplyeeName;
            DepartLabel.Text = MainTableField.DepartName + "部門";
            textBox4.Text = monthCalendar1.TodayDate.ToString("yyyy-MM-dd");

            if(MainTableField.SelectMode == "Update")
            {
                textBox2.Enabled = false;
                textBox2.Text = MainTableField.WorkOrder;
                comboBox1.Text = MainTableField.MainGear;
                comboBox2.Text = MainTableField.Processing;
                MessageBox.Show(MainTableField.Costtime.ToString());
                numericUpDown1.Value =  (decimal)MainTableField.Costtime;
                textBox1.Text = MainTableField.WorkDetail;
                monthCalendar1.TodayDate = DateTime.Parse(MainTableField.WorkDay);
                textBox4.Text = MainTableField.WorkDay;
                insertbutton.Text = "修改";
                LoadingData();
            }
            else
            {
                insertbutton.Enabled = false; 
            }
        }
        private void cancelbutton_Click(object sender, EventArgs e)
        {

        }

        private void insertbutton_Click(object sender, EventArgs e)
        {
            MainTableField.Ordername = textBox3.Text;
            MainTableField.MainGear = comboBox1.Text;
            MainTableField.Processing = comboBox2.Text;
            MainTableField.Costtime = (float)(numericUpDown1.Value);
            MainTableField.WorkDetail = textBox1.Text;
            MainTableField.WorkDay = monthCalendar1.SelectionEnd.ToString("yyyy-MM-dd");
        }

        private void LoadingData()
        {
            connection = new OleDbConnection(@"Provider=Microsoft.ACE.Oledb.12.0;Data Source=.\DB31.accdb;");
            MainTableField.WorkOrder = textBox2.Text;

            //清除現有資料
            comboBox1.Items.Clear();
            comboBox2.Items.Clear();
            textBox1.Text = "";
            textBox3.Text = "";
            try
            {
                String queryString;

                queryString = "SELECT 工令表.*, 主單元表.* " +
                        "FROM 工令表 " +
                        "INNER JOIN 主單元表 ON 工令表.工令代號 = 主單元表.工令代號 " +
                        "WHERE 工令表.工令代號 = " + "'" + MainTableField.WorkOrder + "';";

                OleDbCommand command = new OleDbCommand(queryString, connection);
                connection.Open();
                OleDbDataAdapter dataAdpter = new OleDbDataAdapter(queryString, connection);
                DataSet DataSetValue = new DataSet();
                DataSetValue.Clear();
                dataAdpter.Fill(DataSetValue);

                //判定工令名稱不能為空
                if (DataSetValue.Tables[0].Rows[0]["工令名稱"].ToString() == null)
                {
                    MessageBox.Show("空的");
                }

                //載入資料
                for (int i = 0; i < DataSetValue.Tables[0].Rows.Count; i++)
                {
                    textBox3.Text = DataSetValue.Tables[0].Rows[i]["工令名稱"].ToString();
                    comboBox1.Items.Add(DataSetValue.Tables[0].Rows[i]["主單元名稱"].ToString());
                    comboBox2.Items.Add(DataSetValue.Tables[0].Rows[i]["加工類別"].ToString());
                }
                insertbutton.Enabled = true;
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("找不到該工令");
                insertbutton.Enabled = false;
                /*
                MessageBox.Show("發生錯誤!!!!,請通知IT人員"+"\n"+ex.ToString(),
                    "警告",MessageBoxButtons.OK,MessageBoxIcon.Error);*/
                connection.Close();
            }
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            //沒有工令不能新增工時回報
            if (textBox2.Text != null)
            {
                LoadingData();
            }
            else
            {
                insertbutton.Enabled = false;
            }
        }

        private void monthCalendar1_DateSelected(object sender, DateRangeEventArgs e)
        {
            textBox4.Text = monthCalendar1.SelectionEnd.ToString("yyyy-MM-dd");
        }

    }

}
