using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Windows.Storage.Pickers;
using Windows.Storage;
using Windows.Storage.Streams;
using Windows.Graphics.Imaging;
using Windows.UI.Xaml.Media.Imaging;
using System.IO;

namespace NETLaba10
{
	public partial class Form1 : Form
	{

		private class ArrayPoints
		{
			private int index = 0;
			private Point[] points;
			public ArrayPoints(int size)
			{
				if (size <= 0) size = 2;
				points = new Point[size];
			}
			public void SetPoint(int x, int y)
			{
				if (index >= points.Length) index = 0;
				points[index] = new Point(x, y);
				index++;
			}
			public void ResetPoints()
			{
				index = 0;
			}
			public int GetCountPoints()
			{
				return index;
			}
			public Point[] GetPoints()
			{
				return points;
			}
		}
		private ArrayPoints ap = new ArrayPoints(2);
		private bool isDragging = false;
		string path = @"C:\Users\ayhal\Pictures\Рисунки";
		string file;
		Bitmap b;
		Graphics g;
		Pen pen = new Pen(Color.Black, 5);

		public Form1()
		{
			InitializeComponent();

			b = new Bitmap(pictureBox1.Width, pictureBox1.Height);
			g = Graphics.FromImage(b);
			
			g.Clear(pictureBox1.BackColor);
			pictureBox1.Image = b;
			
			pen.StartCap = System.Drawing.Drawing2D.LineCap.Round;
			pen.EndCap = System.Drawing.Drawing2D.LineCap.Round;
			
			label1.Text = trackBar1.Value.ToString();
			this.Text = "New";

			saveToolStripMenuItem.Enabled = false;
		}

		// SIDE BUTTONS //
		private void trackBar1_Scroll(object sender, EventArgs e)
		{
			pen.Width = trackBar1.Value;
			label1.Text = trackBar1.Value.ToString();
		}

		private void button8_Click(object sender, EventArgs e)
		{
			ColorDialog colorDlg = new ColorDialog();
			colorDlg.Color = pen.Color;
			if (colorDlg.ShowDialog() != DialogResult.Cancel)
			{
				pen.Color = colorDlg.Color;
			}
		}

		private void button9_Click(object sender, EventArgs e)
		{
			g.Clear(pictureBox1.BackColor);
			pictureBox1.Image = b;
		}

		// PAINT //
		private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
		{
				isDragging = true;
		}

		private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
		{
			if(isDragging)
			{
				ap.SetPoint(e.X, e.Y);
				if (ap.GetCountPoints() >= 2)
				{
					g.DrawLines(pen, ap.GetPoints());
					pictureBox1.Image = b;
					ap.SetPoint(e.X, e.Y);
				}
			}
		}

		private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
		{
			isDragging = false;
			ap.ResetPoints();
		}

		// MENU STRIP //
		private void newToolStripMenuItem_Click(object sender, EventArgs e)
		{
			saveToolStripMenuItem.Enabled = false;
			b = new Bitmap(pictureBox1.Width, pictureBox1.Height);
			g = Graphics.FromImage(b);
			this.Text = "New";
			g.Clear(pictureBox1.BackColor);
			pictureBox1.Image = b;
		}

		private void openToolStripMenuItem_Click(object sender, EventArgs e)
		{
			OpenFileDialog open_dialog = new OpenFileDialog();
			open_dialog.InitialDirectory = path;
			open_dialog.Filter = "Image Files(*.BMP;*.JPG;*.GIF;*.PNG)|*.BMP;*.JPG;*.GIF;*.PNG|All files (*.*)|*.*";
			if (open_dialog.ShowDialog() == DialogResult.OK)
			{
				try
				{
					saveToolStripMenuItem.Enabled = true;
					g.Clear(pictureBox1.BackColor);
					b = new Bitmap(open_dialog.FileName);
					g = Graphics.FromImage(b);
					pictureBox1.Image = b;
					pictureBox1.Invalidate();
					file = open_dialog.FileName;
					this.Text = file;
				}
				catch
				{
					DialogResult rezult = MessageBox.Show("Невозможно открыть выбранный файл",
					"Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
			open_dialog.Dispose();
		}

		private void saveToolStripMenuItem_Click(object sender, EventArgs e)
		{
			var newBitmap = new Bitmap(pictureBox1.Width, pictureBox1.Height);
			pictureBox1.DrawToBitmap(newBitmap, pictureBox1.ClientRectangle);
			g.Dispose();
			b.Dispose();
			newBitmap.Save(file);
			b = newBitmap;
			g = Graphics.FromImage(b);
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
						file = savedialog.FileName;
						this.Text = file;
						pictureBox1.Image.Save(savedialog.FileName, System.Drawing.Imaging.ImageFormat.Jpeg);
					}
					catch
					{
						MessageBox.Show("Невозможно сохранить изображение", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
					}
				}
			}
		}

		// COLOR BUTTONS //
		private void button1_Click(object sender, EventArgs e)
		{
			pen.Color = Color.White;
		}

		private void button2_Click(object sender, EventArgs e)
		{
			pen.Color = Color.Black;
		}

		private void button3_Click(object sender, EventArgs e)
		{
			pen.Color = Color.Red;
		}

		private void button4_Click(object sender, EventArgs e)
		{
			pen.Color = Color.Blue;
		}

		private void button5_Click(object sender, EventArgs e)
		{
			pen.Color = Color.Green;
		}

		private void button6_Click(object sender, EventArgs e)
		{
			pen.Color = Color.Orange;
		}

		private void button7_Click(object sender, EventArgs e)
		{
			pen.Color = Color.Purple;
		}
	}
}
