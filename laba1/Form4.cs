using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;
using System.IO;


namespace WindowsFormsApplication3
{
	public partial class Form4 : Form
	{
		public Form4()
		{
			InitializeComponent();
		}
		string[] a;
		string[] b;

		private void Form4_Load(object sender, EventArgs e)
		{
			try
			{
				this.usersTableAdapter.FillBy(this.database1DataSet.Users);
			}
			catch (System.Exception ex)
			{
				System.Windows.Forms.MessageBox.Show(ex.Message);
			}

		}

		private void toolStripButton1_Click(object sender, EventArgs e)
		{
			a = new string[dataGridView1.RowCount];
			b = new string[dataGridView1.RowCount];
			int n, s, sn;
			int maxn = 0;
			int maxs = 0;
			int maxsn = 0;
			for(int i = 0; i < dataGridView1.RowCount - 1; i++)
			{
				a[i] = dataGridView1[2, i].Value.ToString();
				b[i] = dataGridView1[3, i].Value.ToString();
			}
			
			for (int i = 0; i < dataGridView1.RowCount - 1; i++)
			{
				n = 1;
				s = 1;
				sn = 1;
				for (int c = 0; c < dataGridView1.RowCount - 1; c++)
				{
					if (c == i) continue;
					if (a[i] == a[c]) n++;
					if (b[i] == b[c]) s++;
					if (a[i] == a[c] && b[i] == b[c]) sn++;
				}
				if (maxn < n) maxn = n;
				if (maxs < s) maxs = s;
				if (maxsn < sn) maxsn = sn;
			}
			MessageBox.Show("Максимальное количество тёзок"+
				"\nПо имени = "+Convert.ToString(maxn)+
				"\nПо отчеству = "+ Convert.ToString(maxs)+
				"\nПо имени и отчеству = "+ Convert.ToString(maxsn));
		}

		private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}
	}
}
