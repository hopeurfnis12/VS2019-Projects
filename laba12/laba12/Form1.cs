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

namespace laba12
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		string path = @"C:\";
		Bitmap b;

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
						saveAsToolStripMenuItem.Enabled = true;
						button1.Enabled = true;
						button2.Enabled = true;
						button3.Enabled = true;
						button4.Enabled = true;
						button5.Enabled = true;
						button6.Enabled = true;

						b = new Bitmap(open_dialog.FileName);
						pictureBox1.Image = b;
						pictureBox1.Invalidate();
					}
					catch { DialogResult rezult = MessageBox.Show("Невозможно открыть", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error); }
				}
				pictureBox2.Image = pictureBox1.Image;
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
					try { pictureBox1.Image.Save(savedialog.FileName, System.Drawing.Imaging.ImageFormat.Jpeg); }
					catch { MessageBox.Show("Невозможно сохранить", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error); }
				}
			}
		}

		private void button1_Click(object sender, EventArgs e)
		{
			IFilter brightness = new BrightnessCorrection((int)numericUpDown1.Value);
			pictureBox1.Image = brightness.Apply(b);
		}

		private void button2_Click(object sender, EventArgs e)
		{
			IFilter contrast = new ContrastCorrection((int)numericUpDown2.Value);
			pictureBox1.Image = contrast.Apply(b);
		}

		private void button3_Click(object sender, EventArgs e)
		{
			int w = pictureBox2.Image.Width / 100 * (int)numericUpDown3.Value;
			int h = pictureBox2.Image.Height / 100 * (int)numericUpDown3.Value;
			BaseResizeFilter baseResizeFilter = new ResizeBilinear(w, h);
			pictureBox1.Image = baseResizeFilter.Apply(b);
		}

		private void button4_Click(object sender, EventArgs e)
		{
			int[,] kernel = {
				{ -1,  -1,  -1 },
				{ -1,   9,  -1 },
				{ -1,  -1,  -1 }
			};
			IFilter filter = new Convolution(kernel);
			pictureBox1.Image = filter.Apply(b);
		}

		private void button5_Click(object sender, EventArgs e)
		{
			AdaptiveSmoothing adaptiveSmoothing = new AdaptiveSmoothing();
			pictureBox1.Image = adaptiveSmoothing.Apply(b);
		}

		private void button6_Click(object sender, EventArgs e)
		{
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
			pictureBox1.Image = output;
		}
	}
}
