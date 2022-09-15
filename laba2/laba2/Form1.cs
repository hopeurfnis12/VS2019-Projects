using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace laba2
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}



		//////////////////////////////////////////////////////////////// copies
		private void copiesbtn_Click(object sender, EventArgs e)
		{
			string copiesotv = Copies(s1box.Text, ((int)copiesn.Value));
			copiesbox.Text = sbox.Text + copiesotv;
		}
		public static string Copies(string text, int count)
		{
			return string.Join("", Enumerable.Repeat(text, count));
		}
		////////////////////////////////////////////////////////////////////////



		//////////////////////////////////////////////////////////////// words
		private void button2_Click(object sender, EventArgs e)
		{
			int i = 0;
			int x = 0;
			bool t = true;
			while (sbox.Text[i] == ' ') i++;
			for (; i < sbox.Text.Length; i++)
			{
				while(sbox.Text[i] != ' ')
				{
					i++;
					if (i == sbox.Text.Length)
					{
						t = false;
						break;
					}
				}
				if(t == false)
				{
					x++;
					break;
				}
				while (sbox.Text[i] == ' ')
				{
					i++;
					if (i == sbox.Text.Length)
					{
						break;
					}
				}
				x++;
			}
			wordsbox.Text = Convert.ToString(x);
		}
		////////////////////////////////////////////////////////////////////////



		//////////////////////////////////////////////////////////////// parse
		private void button3_Click(object sender, EventArgs e)
		{
			string parseotv = sbox.Text;
			int index = parseotv.IndexOf(parset.Text);
			parsebox1.Text = parseotv.Substring(0, index + 1);
			parsebox2.Text = parseotv.Substring(index + 1);
		}
		////////////////////////////////////////////////////////////////////////



		//////////////////////////////////////////////////////////////// delete
		private void button4_Click(object sender, EventArgs e)
		{
			deletebox.Text = "";
			string s = sbox.Text;
			for (int i = 0; i < sbox.Text.Length; i++)
			{
				if (i == Convert.ToInt32(deleten.Text) - 1)
				{
					i += Convert.ToInt32(deletel.Text);
				}
				deletebox.Text += s[i];
			}
		}
		////////////////////////////////////////////////////////////////////////



		//////////////////////////////////////////////////////////////// insert
		private void button5_Click(object sender, EventArgs e)
		{
			insertbox.Text = "";

			if (((int)insertn.Value) == 0) insertbox.Text += s1box.Text;
			for (int i = 0; i < sbox.Text.Length; i++)
			{
				insertbox.Text += sbox.Text[i];
				if(((int)insertn.Value) - 1 == i){
					insertbox.Text += s1box.Text;
				}
			}
		}
		////////////////////////////////////////////////////////////////////////



		//////////////////////////////////////////////////////////////// reverse
		private void button6_Click(object sender, EventArgs e)
		{
			reversebox.Text = "";
			for (int i = sbox.Text.Length - 1; i >= 0; i--)
			{
				reversebox.Text += sbox.Text[i];
			}
		}
		////////////////////////////////////////////////////////////////////////



		//////////////////////////////////////////////////////////////// pos
		private void button7_Click(object sender, EventArgs e)
		{
			int x = 0;
			bool t = false;
			for (int i = 0; i < sbox.Text.Length; i++)
			{
				if (i + (s1box.Text.Length - 1) < sbox.Text.Length)
					for (int c = 0; c < s1box.Text.Length; c++)
					{
						if(sbox.Text[i + c] == s1box.Text[c])
						{
							x++;
						}
						if (s1box.Text.Length == x)
						{
							t = true;
						}
					}
				if (t == true)
				{
					i += 1;
					posbox.Text = Convert.ToString(i);
					break;
				}
			}
			if(t == false)
			{
				posbox.Text = "Вхождений не найдено";
			}
		}
		////////////////////////////////////////////////////////////////////////



		//////////////////////////////////////////////////////////////// lastpos
		private void button8_Click(object sender, EventArgs e)
		{
			int x = 0;
			bool t = false;
			bool b = false;
			for (int i = 0; i < sbox.Text.Length; i++)
			{
				if(i + (s1box.Text.Length - 1) < sbox.Text.Length)
					for (int c = 0; c < s1box.Text.Length; c++)
					{
						if(sbox.Text[i + c] == s1box.Text[c])
						{
							x++;
						}
						if (s1box.Text.Length == x)
						{
							t = true;
							b = true;
						}
					}
				if (t == true)
				{
					lastposbox.Text = Convert.ToString(i + 1);
					t = false;
					x = 0;
				}
			}
			if(t == false && b == false)
			{
				lastposbox.Text = "Вхождений не найдено";
			}
		}
		////////////////////////////////////////////////////////////////////////



		//////////////////////////////////////////////////////////////// trim
		private void button9_Click(object sender, EventArgs e)
		{
			trimbox.Text = "";
			int i = 0;
			int c = sbox.Text.Length - 1;
			while (sbox.Text[i] == ' ') i++;
			while (sbox.Text[c] == ' ') c--;
			for (; i <= c; i++)
			{
				trimbox.Text += sbox.Text[i];
			}
		}
		////////////////////////////////////////////////////////////////////////



		//////////////////////////////////////////////////////////////// word
		private void button10_Click(object sender, EventArgs e)
		{
			wordbox.Text = "";
			int i = 0;
			while (sbox.Text[i] == ' ') i++;
			for (; i < sbox.Text.Length; i++)
			{
				if((sbox.Text[i] == ' ') || (sbox.Text[i] == ',') || (sbox.Text[i] == '.'))
				{
					break;
				}
				wordbox.Text += sbox.Text[i];
			}
		}
		////////////////////////////////////////////////////////////////////////

	}
}
