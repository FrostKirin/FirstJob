using System.Data.OleDb;
using System.Data;
using System.Xml;
using System;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();

            
        }

        private void Form1_Load(object sender, EventArgs e)
        {


        }

        private void button1_Click(object sender, EventArgs e)
        {
            String Departmant = "",Identifiy = "";
            Departmant = comboBox1.Text;
            Identifiy = textBox1.Text;
            

            bool IsFundEmplyee = false;

            string DBName = "DB31.accdb"; //資料庫名稱

            
            OleDbConnection connection = new OleDbConnection(@"Provider=Microsoft.ACE.Oledb.12.0;Data Source=.\" + DBName + ";");
            connection.Open();

            String queryString;
            queryString = "SELECT * FROM 員工資料";

            OleDbCommand command = new OleDbCommand(queryString, connection);
            DataSet DataSetValue = new DataSet();
            OleDbDataAdapter dataAdpter = new OleDbDataAdapter(queryString, connection);
            DataSetValue.Clear();
            dataAdpter.Fill(DataSetValue);

            for (int i = 0; i < DataSetValue.Tables[0].Rows.Count; i++)
            {
                if (Departmant == DataSetValue.Tables[0].Rows[i]["部門"].ToString() &&
                    Identifiy == DataSetValue.Tables[0].Rows[i]["員工編號"].ToString())
                {
                    IsFundEmplyee = true;
                }
            }
            if (IsFundEmplyee)
            {
                Form2 f = new Form2(Identifiy, Departmant);
                f.ShowDialog(this);
            }
            else
            {
                MessageBox.Show("查無此人");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
