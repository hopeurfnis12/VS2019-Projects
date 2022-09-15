using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NETLaba7.UI
{
	public partial class Task2 : Form
	{
		public Task2()
		{
			InitializeComponent();
		}

		private void Task2_Load(object sender, EventArgs e)
		{
            f_load();
        }

        private void f_load()
		{
            listBox1.Items.Clear();
            string connStr = "server=localhost; port=3306; username=root; password=root; database=university;";
            string sql = "SELECT DISTINCT surname FROM student;";
            MySqlConnection conn = new MySqlConnection(connStr);
            MySqlCommand command = new MySqlCommand(sql, conn);
            MySqlDataReader reader;
            try
            {
                command.Connection.Open();
                reader = command.ExecuteReader();

                while (reader.Read())
                {
                    listBox1.Items.Add(reader["surname"].ToString());
                }
                reader.Close();
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Error", ex.ToString());
            }
            finally
            {
                command.Connection.Close();
            }
        }

        private void db_load()
        {
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();
            dataGridView1.Refresh();
            if (listBox1.SelectedIndex == -1)
            {
                listBox1.SelectedIndex = 0;
                listBox1.SelectedItem = 0;
            }
            this.Text = listBox1.SelectedItem.ToString();
            //MessageBox.Show(listBox1.SelectedItem.ToString());
            string connStr = "server=localhost; port=3306; username=root; password=root; database=university;";
            string sql = "SELECT student_id, surname, name, kurs, city, birthday FROM student " +
                "where surname = '" + listBox1.SelectedItem.ToString() + "';";
            MySqlConnection conn = new MySqlConnection(connStr);
            MySqlCommand command = new MySqlCommand(sql, conn);
            MySqlDataReader reader;
            try
            {
                command.Connection.Open();
                reader = command.ExecuteReader();
                this.dataGridView1.Columns.Add("student_id", "Id");
                this.dataGridView1.Columns["student_id"].Width = 50;

                this.dataGridView1.Columns.Add("surname", "Surname");
                this.dataGridView1.Columns["surname"].Width = 100;

                this.dataGridView1.Columns.Add("name", "Name");
                this.dataGridView1.Columns["name"].Width = 80;

                this.dataGridView1.Columns.Add("kurs", "Kurs");
                this.dataGridView1.Columns["kurs"].Width = 50;

                this.dataGridView1.Columns.Add("city", "City");
                this.dataGridView1.Columns["city"].Width = 60;

                this.dataGridView1.Columns.Add("birthday", "Birthday");
                this.dataGridView1.Columns["birthday"].Width = 100;

                while (reader.Read())
                {
                    dataGridView1.Rows.Add(reader["student_id"].ToString(), reader["surname"].ToString(), reader["name"].ToString(),
                        reader["kurs"].ToString(), reader["city"].ToString(), Convert.ToDateTime(reader["birthday"]).ToString("dd.MM.yyyy"));
                }
                reader.Close();
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Error", ex.ToString());
            }
            finally
            {
                command.Connection.Close();
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
		{
            if (listBox1.SelectedIndex != -1)
            {
                db_load();
                f_load();
            }
        }

		private void button1_Click(object sender, EventArgs e)
		{
            this.Hide();
            Task3 task3 = new Task3();
            task3.Show();
            task3.FormClosed += (object s, FormClosedEventArgs ev) => { this.Show(); f_load(); };
        }

		private void button2_Click(object sender, EventArgs e)
		{
            int a, b;
            if (dataGridView1.SelectedRows != null)
            {
                b = dataGridView1.CurrentRow.Index;
                a = Convert.ToInt32(dataGridView1.Rows[b].Cells[0].Value);
                DialogResult dialogResult = MessageBox.Show("Действительно удалить запись в БД?", "Удаление", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    string connStr = "server=localhost; port=3306; username=root; password=root; database=university;";
                    string sql = "DELETE FROM student WHERE student_id = " + a + ";";
                    MySqlConnection conn = new MySqlConnection(connStr);
                    conn.Open();
                    MySqlCommand command = new MySqlCommand(sql, conn);
                    command.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("Удалено");
                    dataGridView1.Rows.Clear();
                    dataGridView1.Columns.Clear();
                    dataGridView1.Refresh();
                    this.Text = "Task2/3";
                    f_load();
                }
            }
        }
	}
}
