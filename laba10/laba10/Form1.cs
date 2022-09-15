using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace laba10
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
			b = new Bitmap(pictureBox1.Width, pictureBox1.Height);
			g = Graphics.FromImage(b);
			g.Clear(pictureBox1.BackColor);
			pictureBox1.Image = b;
		}

		private Point p = new Point();
		private int task = 0;
		private bool lastpoint = false;
		string path = @"C:\";
		Bitmap b;
		Graphics g;
		Pen pen = new Pen(Color.Black, 2);


		private void newToolStripMenuItem_Click(object sender, EventArgs e)
		{
			b = new Bitmap(pictureBox1.Width, pictureBox1.Height);
			g = Graphics.FromImage(b);
			pictureBox1.BackColor = Color.White;
			g.Clear(pictureBox1.BackColor);
			pictureBox1.Image = b;

			drawToolStripMenuItem.Enabled = true;
			saveAsToolStripMenuItem.Enabled = true;
		}

		private void openToolStripMenuItem_Click(object sender, EventArgs e)
		{
			using (OpenFileDialog open_dialog = new OpenFileDialog())
			{
				open_dialog.InitialDirectory = path;
				open_dialog.Filter = "Image Files(*.BMP;*.JPG;*.GIF;*.PNG)|*.BMP;*.JPG;*.GIF;*.PNG|All files (*.*)|*.*";
				if (open_dialog.ShowDialog() == DialogResult.OK)
				{
					try
					{
						g.Clear(pictureBox1.BackColor);
						b = new Bitmap(open_dialog.FileName);
						g = Graphics.FromImage(b);
						pictureBox1.Image = b;
						pictureBox1.Size = b.Size;
						pictureBox1.Invalidate();

						drawToolStripMenuItem.Enabled = true;
						saveAsToolStripMenuItem.Enabled = true;
					}
					catch
					{
						DialogResult rezult = MessageBox.Show("Невозможно открыть", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
					}
				}
				open_dialog.Dispose();
			}
		}
		private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
		{
			using (SaveFileDialog savedialog = new SaveFileDialog())
			{
				savedialog.Title = "Сохранить картинку как...";
				savedialog.InitialDirectory = path;
				savedialog.Filter = "Image Files(*.JPG)|*.JPG|Image Files(*.PNG)|*.PNG|All files (*.*)|*.*";
				if (savedialog.ShowDialog() == DialogResult.OK)
				{
					try
					{
						pictureBox1.Image.Save(savedialog.FileName, System.Drawing.Imaging.ImageFormat.Jpeg);
					}
					catch
					{
						MessageBox.Show("Невозможно сохранить", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
					}
				}
			}
		}

		private void toolStripMenuItem2_Click(object sender, EventArgs e) { task = 1; }
		private void toolStripMenuItem3_Click(object sender, EventArgs e) { task = 2; }
		private void toolStripMenuItem4_Click(object sender, EventArgs e) { task = 3; }

		private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
		{
			if (task == 1)
			{
				var rand = new Random();
				int wh = rand.Next(1, 100);
				SolidBrush brush = new SolidBrush(Color.FromArgb(rand.Next(256), rand.Next(256), rand.Next(256)));
				g.FillEllipse(brush, e.X - wh / 2, e.Y - wh / 2, wh, wh);
				pictureBox1.Image = b;
			}

			if (task == 2)
			{
				var rand = new Random();
				int n = rand.Next(1, 20);
				for (int i = 3; i <= n; i++)
				{
					int s = i * 10;
					g.DrawEllipse(pen, e.X - s / 2, e.Y - s / 2, s, s);
				}
				pictureBox1.Image = b;
			}

			if (task == 3)
			{
				if (!lastpoint)
				{
					p.X = e.X;
					p.Y = e.Y;
					lastpoint = true;
				}
				else
				{
					lastpoint = false;
					var rand = new Random();
					int x;
					int y;
					int n = rand.Next(5, 15);
					x = (e.X - p.X) / n;
					y = (e.Y - p.Y) / n;
					for (int i = n; i > 0; i--)
					{
						p.X += x;
						p.Y += y;
						int s = i * 5;
						g.DrawEllipse(pen, p.X - s / 2, p.Y - s / 2, s, s);
					}
					pictureBox1.Image = b;
				}
			}
		}

	}
}
