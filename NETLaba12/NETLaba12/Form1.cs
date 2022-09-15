using AForge.Imaging.Filters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NETLaba12
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();

			this.Text = "New";
			label1.Text = trackBar1.Value.ToString();

			saveToolStripMenuItem.Enabled = false;
		}
		int method = 0;
		string path = @"C:\Users\ayhal\Downloads";
		string file;
		Bitmap b;

		private void brightnessToolStripMenuItem_Click(object sender, EventArgs e)
		{
			trackBar1.Enabled = true;
			trackBar1.Minimum = -100;
			trackBar1.Maximum = 100;
			trackBar1.Value = 0;
			label1.Text = trackBar1.Value.ToString();
			method = 1;
		}

		private void contrastToolStripMenuItem_Click(object sender, EventArgs e)
		{
			trackBar1.Enabled = true;
			trackBar1.Minimum = -100;
			trackBar1.Maximum = 100;
			trackBar1.Value = 0;
			label1.Text = trackBar1.Value.ToString();
			method = 2;
		}

		private void resizeToolStripMenuItem_Click(object sender, EventArgs e)
		{
			trackBar1.Enabled = true;
			trackBar1.Minimum = 1;
			trackBar1.Maximum = 100;
			trackBar1.Value = 100;
			label1.Text = trackBar1.Value.ToString() + "%";
			method = 3;
		}
		private void convolutionToolStripMenuItem_Click(object sender, EventArgs e)
		{
			trackBar1.Enabled = false;
			Bitmap bmp = (Bitmap)pictureBox1.Image;
			int[,] kernel = {
				{ -1,  -1,  -1 },
				{ -1,   9,  -1 },
				{ -1,  -1,  -1 }
			};
			IFilter filter = new Convolution(kernel);
			pictureBox2.Image = filter.Apply(bmp);
		}
		private void adaptiveSmoothingToolStripMenuItem_Click(object sender, EventArgs e)
		{
			trackBar1.Enabled = false;
			Bitmap bmp = (Bitmap)pictureBox1.Image;
			AdaptiveSmoothing adaptiveSmoothing = new AdaptiveSmoothing();
			pictureBox2.Image = adaptiveSmoothing.Apply(bmp);
		}
		private void sepiaToolStripMenuItem_Click(object sender, EventArgs e)
		{
			trackBar1.Enabled = false;
			Bitmap input = new Bitmap(pictureBox1.Image);
			Bitmap output = new Bitmap(input.Width, input.Height);
			for (int j = 0; j < input.Height; j++)
				for (int i = 0; i < input.Width; i++)
				{
					UInt32 pixel = (UInt32)(input.GetPixel(i, j).ToArgb());
					float R = (float)((pixel & 0x00FF0000) >> 16);
					float G = (float)((pixel & 0x0000FF00) >> 8);
					float B = (float)(pixel & 0x000000FF);
					R = G = B = (R + G + B) / 3.0f;
					UInt32 newPixel = 0xFF000000 | ((UInt32)R << 16) | ((UInt32)G << 8) | ((UInt32)B);
					output.SetPixel(i, j, Color.FromArgb((int)newPixel));
				}
			pictureBox2.Image = output;
		}


		private void trackBar1_Scroll(object sender, EventArgs e)
		{
			if (pictureBox1.Image != null)
			{
				label1.Text = trackBar1.Value.ToString();
				Bitmap bmp = (Bitmap)pictureBox1.Image;
				switch (method)
				{
					case 1: // brightness
						IFilter brightness = new BrightnessCorrection(trackBar1.Value);
						pictureBox2.Image = brightness.Apply(bmp);
						break;
					case 2: // contrast
						IFilter contrast = new ContrastCorrection(trackBar1.Value);
						pictureBox2.Image = contrast.Apply(bmp);
						break;
					case 3: // resize
						label1.Text += "%";
						//MessageBox.Show(Convert.ToString(pictureBox1.Height) + " " + Convert.ToString(pictureBox1.Image.Height));
						//MessageBox.Show(Convert.ToString(pictureBox2.Height) + " " + Convert.ToString(pictureBox2.Image.Height));
						int w = pictureBox1.Image.Width / 100 * trackBar1.Value;
						int h = pictureBox1.Image.Height / 100 * trackBar1.Value;
						BaseResizeFilter baseResizeFilter = new ResizeBilinear(w, h);
						pictureBox2.Image = baseResizeFilter.Apply(bmp);
						break;
					case 0:
						MessageBox.Show("Выберит метод!");
						break;
				}
			}
			else
			{
				MessageBox.Show("Выберит файл!");
			}
			
		}

		// MENU STRIP //

		private void openToolStripMenuItem_Click(object sender, EventArgs e)
		{
			brightnessToolStripMenuItem.Enabled = true;
			contrastToolStripMenuItem.Enabled = true;
			resizeToolStripMenuItem.Enabled = true;
			adaptiveSmoothingToolStripMenuItem.Enabled = true;
			sepiaToolStripMenuItem.Enabled = true;
			originToolStripMenuItem.Enabled = true;
			convolutionToolStripMenuItem.Enabled = true;
			trackBar1.Enabled = true;

			OpenFileDialog open_dialog = new OpenFileDialog();
			open_dialog.InitialDirectory = path;
			open_dialog.Filter = "Image Files(*.BMP;*.JPG;*.GIF;*.PNG)|*.BMP;*.JPG;*.GIF;*.PNG|All files (*.*)|*.*";
			if (open_dialog.ShowDialog() == DialogResult.OK)
			{
				try
				{
					saveToolStripMenuItem.Enabled = true;
					b = new Bitmap(open_dialog.FileName);
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
			pictureBox2.Image = pictureBox1.Image;
			open_dialog.Dispose();
		}

		private void saveToolStripMenuItem_Click(object sender, EventArgs e)
		{
			var newBitmap = new Bitmap(pictureBox2.Width, pictureBox2.Height);
			pictureBox2.DrawToBitmap(newBitmap, pictureBox2.ClientRectangle);
			b.Dispose();
			newBitmap.Save(file);
			b = newBitmap;
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
						pictureBox2.Image.Save(savedialog.FileName, System.Drawing.Imaging.ImageFormat.Jpeg);
					}
					catch
					{
						MessageBox.Show("Невозможно сохранить изображение", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
					}
				}
			}
		}
		private void originToolStripMenuItem_MouseDown(object sender, MouseEventArgs e)
		{
			pictureBox1.Visible = true;
			pictureBox2.Visible = false;
		}
		private void originToolStripMenuItem_MouseUp(object sender, MouseEventArgs e)
		{
			pictureBox1.Visible = false;
			pictureBox2.Visible = true;
		}
	}
}
