using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NETLaba6
{
	public partial class Artist : Form
	{
		string name_artist;
		string der_artist;
		int id_pic;
		public Artist()
		{
			InitializeComponent();
		}

		private void label1_Click(object sender, EventArgs e)
		{
		}

		public void id_artist(string name)
		{
			name_artist = name;
			der_artist = "..\\..\\Artists\\" + name + "\\";
			this.Text = name_artist;
			id_pic = 1;
			pictureBox1.Image = Image.FromFile(der_artist + "img\\" + id_pic + ".jpg");
			groupBox2.Text = File.ReadAllText(der_artist + "img\\" + id_pic + ".txt");
			textBox1.Text = File.ReadAllText(der_artist + "bio.txt");
		}

		private void Artist_FormClosed(object sender, FormClosedEventArgs e)
		{
			Main main = new Main();
			main.Show();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			id_pic++;
			if (File.Exists(der_artist + "img\\" + id_pic + ".jpg"))
			{
				pictureBox1.Image = Image.FromFile(der_artist + "img\\" + id_pic + ".jpg");
				groupBox2.Text = File.ReadAllText(der_artist + "img\\" + id_pic + ".txt");
			}
			else id_pic--;
		}

		private void button2_Click(object sender, EventArgs e)
		{
			id_pic--;
			if (File.Exists(der_artist + "img\\" + id_pic + ".jpg"))
			{
				pictureBox1.Image = Image.FromFile(der_artist + "img\\" + id_pic + ".jpg");
				groupBox2.Text = File.ReadAllText(der_artist + "img\\" + id_pic + ".txt");
			}
			else id_pic++;
		}
	}
}
