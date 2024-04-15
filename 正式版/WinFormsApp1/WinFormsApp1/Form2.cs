using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form2 : Form
    {
        string DBName = "DB31.accdb"; //資料庫名稱
        public string TableName = "員工工令主表";
        public string PickNum = "";
        public int pickindex;
        OleDbConnection connection = new OleDbConnection();

        public Form2(string IdNum, String Name)
        {
            connection = new OleDbConnection(@"Provider=Microsoft.ACE.Oledb.12.0;Data Source=.\" + DBName + ";");
            InitializeComponent();

            refrashTable(IdNum);
            MainTableField.EmplyeeID = IdNum;
            MainTableField.DepartName = Name;

            //自動調整寬度
            dataGridView1.AutoResizeColumns();

            //設定Label文字
            NameLabel.Text = MainTableField.EmplyeeID + MainTableField.EmplyeeName;
            DepartLabel.Text = MainTableField.DepartName + " 部門";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //返回按鈕
            this.Close();
        }

        
        bool Onetime = true;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //選擇要修改的資訊
            pickindex = dataGridView1.CurrentRow.Index;
            if (dataGridView1.Rows[pickindex].Cells[0].Value.ToString() != "")
            {
                PickNum = (string)dataGridView1.Rows[pickindex].Cells[0].Value;
            }
            if (Onetime)
            {
                //提示不能直接在表修改
                MessageBox.Show("請不要直接在表格上編輯,不會有反應的","提醒"
                    ,MessageBoxButtons.OK ,MessageBoxIcon.Warning);
                
                Onetime = false;
            }

        }

        //新增資料
        private void insertbutton_Click(object sender, EventArgs e)
        {
            MainTableField.SelectMode = "Insert";
            Form3 input = new Form3();
            DialogResult dr = input.ShowDialog();
            if (dr == DialogResult.OK)
            {
                //與資料庫建立連結
                connection.Open();

                //資料庫語法
                String queryString = "INSERT INTO "+TableName+
                    " ([工令], [工令名稱], [主單元], [加工類別], [花費時間], [工作內容], [執行當日], [員工編號], [員工姓名], [部門]) VALUES ('"
                    + MainTableField.WorkOrder + "','" 
                    + MainTableField.Ordername + "','" 
                    + MainTableField.MainGear + "','" 
                    + MainTableField.Processing + "','"
                    + MainTableField.Costtime + "','"
                    + MainTableField.WorkDetail + "','"
                    + MainTableField.WorkDay + "','"
                    + MainTableField.EmplyeeID + "','"
                    + MainTableField.EmplyeeName + "','"
                    + MainTableField.DepartName +
                    "')";
                OleDbCommand command = new OleDbCommand(queryString, connection);
                if (command.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("已新增資料");

                    //重新讀取資料
                    refrashTable(MainTableField.EmplyeeID);
                }
                //關閉連線
                connection.Close();

            }
        }
        //修改資料
        private void updatebutton_Click(object sender, EventArgs e)
        {
            MainTableField.SelectMode = "Update";
            if(pickindex < dataGridView1.RowCount - 1)
            {
                MainTableField.WorkOrder = dataGridView1.Rows[pickindex].Cells[1].Value.ToString();
                MainTableField.MainGear = dataGridView1.Rows[pickindex].Cells[3].Value.ToString();
                MainTableField.Processing = dataGridView1.Rows[pickindex].Cells[4].Value.ToString();
                MainTableField.Costtime = float.Parse(dataGridView1.Rows[pickindex].Cells[5].Value.ToString());
                MainTableField.WorkDetail = dataGridView1.Rows[pickindex].Cells[6].Value.ToString();
                MainTableField.WorkDay = dataGridView1.Rows[pickindex].Cells[7].Value.ToString();
                
                
            Form3 input = new Form3();
            DialogResult dr = input.ShowDialog();
            if (dr == DialogResult.OK)
            {
                connection.Open();
                
                //資料庫語法
                String queryString =
                    "UPDATE "+TableName+" SET [工令名稱] = '" + MainTableField.Ordername + "', " +
                    "[主單元] = '" + MainTableField.MainGear + "', " +
                    "[加工類別] = '" + MainTableField.Processing  +"', " +
                    "[花費時間] = '" + MainTableField.Costtime.ToString() + "', " +
                    "[工作內容] = '" + MainTableField.WorkDetail + "', " +
                    "[執行當日] = '" + MainTableField.WorkDay + "' WHERE [紀錄編號] = "+PickNum;
                OleDbCommand command = new OleDbCommand(queryString, connection);
                if (command.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("已更新資料");
                    connection.Close();

                    //重新讀取資料
                    refrashTable(MainTableField.EmplyeeID);
                    
                }
            }
            }

        }
        //刪除資料
        private void deletebutton_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("你要刪除的是編號: "+ PickNum+" 的資料", "提醒", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                connection.Open();

                String queryString = "DELETE FROM "+TableName+" WHERE [紀錄編號] = " + PickNum;

                OleDbCommand command = new OleDbCommand(queryString, connection);
                command.ExecuteNonQuery();
                connection.Close();

                //重新讀取資料
                refrashTable(MainTableField.EmplyeeID);

            }
            //關閉連線
            connection.Close();

        }
        private void refrashButton_Click(object sender, EventArgs e)
        {
            //刷新按鈕
            refrashTable(MainTableField.EmplyeeID);
        }

        //刷新表格副程式
        private void refrashTable(string IdNum)
        {

            String queryString;
            queryString = "SELECT * FROM "+TableName;

            OleDbCommand command = new OleDbCommand(queryString, connection);

            OleDbDataAdapter dataAdpter = new OleDbDataAdapter(queryString, connection);
            DataSet DataSetValue = new DataSet();
            DataSetValue.Clear();
            dataAdpter.Fill(DataSetValue);

            //宣告要show出來的表格
            DataTable DataTable = new DataTable();
            DataTable.Columns.Add("紀錄編號");
            DataTable.Columns.Add("工令");
            DataTable.Columns.Add("工令名稱");
            DataTable.Columns.Add("主單元");
            DataTable.Columns.Add("加工類別");
            DataTable.Columns.Add("花費時間");
            DataTable.Columns.Add("工作內容");
            DataTable.Columns.Add("執行當日");

            //篩選登入者的資料
            for (int i = 0; i < DataSetValue.Tables[0].Rows.Count; i++)
            {
                if (IdNum == DataSetValue.Tables[0].Rows[i]["員工編號"].ToString())
                {
                    MainTableField.EmplyeeName = DataSetValue.Tables[0].Rows[i]["員工姓名"].ToString();
                    DateTime executionDate = (DateTime)DataSetValue.Tables[0].Rows[i]["執行當日"];
                    string formattedDate = executionDate.ToString("yyyy-MM-dd");

                    DataTable.Rows.Add(new string[] { DataSetValue.Tables[0].Rows[i]["紀錄編號"].ToString(),
                        DataSetValue.Tables[0].Rows[i]["工令"].ToString(),
                        DataSetValue.Tables[0].Rows[i]["工令名稱"].ToString(),
                        DataSetValue.Tables[0].Rows[i]["主單元"].ToString(),
                        DataSetValue.Tables[0].Rows[i]["加工類別"].ToString(),
                        DataSetValue.Tables[0].Rows[i]["花費時間"].ToString(),
                        DataSetValue.Tables[0].Rows[i]["工作內容"].ToString(),
                        formattedDate });

                }
            }
            dataGridView1.DataSource = DataTable;
        }

        private void EscapeBtn(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
