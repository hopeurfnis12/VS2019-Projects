using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace MyAPP
{
    public partial class Form4 : Form
    {
        public static string connectString = "Provider = Microsoft.Jet.OLEDB.4.0;Data Source = CompanyDB.mdb";
        private OleDbConnection myConnection;

        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            myConnection = new OleDbConnection(connectString);
            myConnection.Open();
            string s = textBox1.Text;
            
            string query1 = "Select Телефон, Дата_рождения, Адрес FROM Данные WHERE Код_cотрудника Like '%" + s + "%'";
            OleDbDataAdapter command1 = new OleDbDataAdapter(query1, myConnection);
            DataTable dt1 = new DataTable();
            command1.Fill(dt1);
            dataGridView1.DataSource = dt1;

            string query2 = "Select Имя, Должность FROM Сотрудники WHERE Код_сотрудника LIKE " + s;
            OleDbDataAdapter command2 = new OleDbDataAdapter(query2, myConnection);
            DataTable dt2 = new DataTable();
            command2.Fill(dt2);
            dataGridView2.DataSource = dt2;
            myConnection.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
