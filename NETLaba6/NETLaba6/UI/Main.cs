using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NETLaba6
{
	public partial class Main : Form
	{
		public Main()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			Artist artist = new Artist();
			//MessageBox.Show(Convert.ToString(listBox1.SelectedIndex));
			artist.id_artist(listBox1.Text);
			artist.Show();
			Hide();
		}

		private void Main_FormClosed(object sender, FormClosedEventArgs e)
		{
			Application.Exit();
		}
	}
}
