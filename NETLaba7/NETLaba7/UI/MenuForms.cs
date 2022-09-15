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
	public partial class MenuForms : Form
	{
		public MenuForms()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			this.Hide();
			Task1 task1 = new Task1();
			task1.Show();
			task1.FormClosed += (object s, FormClosedEventArgs ev) => { this.Show(); };
		}

		private void button2_Click(object sender, EventArgs e)
		{
			this.Hide();
			Task2 task2 = new Task2();
			task2.Show();
			task2.FormClosed += (object s, FormClosedEventArgs ev) => { this.Show(); };
		}

		private void button3_Click(object sender, EventArgs e)
		{
			this.Hide();
			Task3 task3 = new Task3();
			task3.Show();
			task3.FormClosed += (object s, FormClosedEventArgs ev) => { this.Show(); };
		}
	}
}
