
namespace NETLaba12
{
	partial class Form1
	{
		/// <summary>
		/// Обязательная переменная конструктора.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Освободить все используемые ресурсы.
		/// </summary>
		/// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Код, автоматически созданный конструктором форм Windows

		/// <summary>
		/// Требуемый метод для поддержки конструктора — не изменяйте 
		/// содержимое этого метода с помощью редактора кода.
		/// </summary>
		private void InitializeComponent()
		{
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.brightnessToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.contrastToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.resizeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.convolutionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.adaptiveSmoothingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.sepiaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.originToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.panel1 = new System.Windows.Forms.Panel();
			this.label1 = new System.Windows.Forms.Label();
			this.trackBar1 = new System.Windows.Forms.TrackBar();
			this.panel2 = new System.Windows.Forms.Panel();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.menuStrip1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
			this.panel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.menuStrip1.Font = new System.Drawing.Font("Yu Gothic UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(5);
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem,
            this.brightnessToolStripMenuItem,
            this.contrastToolStripMenuItem,
            this.resizeToolStripMenuItem,
            this.convolutionToolStripMenuItem,
            this.adaptiveSmoothingToolStripMenuItem,
            this.sepiaToolStripMenuItem,
            this.originToolStripMenuItem});
			this.menuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Margin = new System.Windows.Forms.Padding(5);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Padding = new System.Windows.Forms.Padding(0, 5, 5, 5);
			this.menuStrip1.Size = new System.Drawing.Size(825, 35);
			this.menuStrip1.TabIndex = 2;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// menuToolStripMenuItem
			// 
			this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem});
			this.menuToolStripMenuItem.Font = new System.Drawing.Font("Yu Gothic UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
			this.menuToolStripMenuItem.Size = new System.Drawing.Size(46, 25);
			this.menuToolStripMenuItem.Text = "File";
			// 
			// openToolStripMenuItem
			// 
			this.openToolStripMenuItem.Font = new System.Drawing.Font("Yu Gothic UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.openToolStripMenuItem.Name = "openToolStripMenuItem";
			this.openToolStripMenuItem.Size = new System.Drawing.Size(130, 26);
			this.openToolStripMenuItem.Text = "Open";
			this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
			// 
			// saveToolStripMenuItem
			// 
			this.saveToolStripMenuItem.Font = new System.Drawing.Font("Yu Gothic UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
			this.saveToolStripMenuItem.Size = new System.Drawing.Size(130, 26);
			this.saveToolStripMenuItem.Text = "Save";
			this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
			// 
			// saveAsToolStripMenuItem
			// 
			this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
			this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(130, 26);
			this.saveAsToolStripMenuItem.Text = "Save as";
			this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
			// 
			// brightnessToolStripMenuItem
			// 
			this.brightnessToolStripMenuItem.Enabled = false;
			this.brightnessToolStripMenuItem.Font = new System.Drawing.Font("Yu Gothic UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.brightnessToolStripMenuItem.Name = "brightnessToolStripMenuItem";
			this.brightnessToolStripMenuItem.Size = new System.Drawing.Size(94, 25);
			this.brightnessToolStripMenuItem.Text = "Brightness";
			this.brightnessToolStripMenuItem.Click += new System.EventHandler(this.brightnessToolStripMenuItem_Click);
			// 
			// contrastToolStripMenuItem
			// 
			this.contrastToolStripMenuItem.Enabled = false;
			this.contrastToolStripMenuItem.Name = "contrastToolStripMenuItem";
			this.contrastToolStripMenuItem.Size = new System.Drawing.Size(80, 25);
			this.contrastToolStripMenuItem.Text = "Contrast";
			this.contrastToolStripMenuItem.Click += new System.EventHandler(this.contrastToolStripMenuItem_Click);
			// 
			// resizeToolStripMenuItem
			// 
			this.resizeToolStripMenuItem.Enabled = false;
			this.resizeToolStripMenuItem.Name = "resizeToolStripMenuItem";
			this.resizeToolStripMenuItem.Size = new System.Drawing.Size(65, 25);
			this.resizeToolStripMenuItem.Text = "Resize";
			this.resizeToolStripMenuItem.Click += new System.EventHandler(this.resizeToolStripMenuItem_Click);
			// 
			// convolutionToolStripMenuItem
			// 
			this.convolutionToolStripMenuItem.Enabled = false;
			this.convolutionToolStripMenuItem.Name = "convolutionToolStripMenuItem";
			this.convolutionToolStripMenuItem.Size = new System.Drawing.Size(106, 25);
			this.convolutionToolStripMenuItem.Text = "Convolution";
			this.convolutionToolStripMenuItem.Click += new System.EventHandler(this.convolutionToolStripMenuItem_Click);
			// 
			// adaptiveSmoothingToolStripMenuItem
			// 
			this.adaptiveSmoothingToolStripMenuItem.Enabled = false;
			this.adaptiveSmoothingToolStripMenuItem.Name = "adaptiveSmoothingToolStripMenuItem";
			this.adaptiveSmoothingToolStripMenuItem.Size = new System.Drawing.Size(157, 25);
			this.adaptiveSmoothingToolStripMenuItem.Text = "AdaptiveSmoothing";
			this.adaptiveSmoothingToolStripMenuItem.Click += new System.EventHandler(this.adaptiveSmoothingToolStripMenuItem_Click);
			// 
			// sepiaToolStripMenuItem
			// 
			this.sepiaToolStripMenuItem.Enabled = false;
			this.sepiaToolStripMenuItem.Name = "sepiaToolStripMenuItem";
			this.sepiaToolStripMenuItem.Size = new System.Drawing.Size(59, 25);
			this.sepiaToolStripMenuItem.Text = "Sepia";
			this.sepiaToolStripMenuItem.Click += new System.EventHandler(this.sepiaToolStripMenuItem_Click);
			// 
			// originToolStripMenuItem
			// 
			this.originToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
			this.originToolStripMenuItem.Enabled = false;
			this.originToolStripMenuItem.Name = "originToolStripMenuItem";
			this.originToolStripMenuItem.Size = new System.Drawing.Size(65, 25);
			this.originToolStripMenuItem.Text = "Origin";
			this.originToolStripMenuItem.MouseDown += new System.Windows.Forms.MouseEventHandler(this.originToolStripMenuItem_MouseDown);
			this.originToolStripMenuItem.MouseUp += new System.Windows.Forms.MouseEventHandler(this.originToolStripMenuItem_MouseUp);
			// 
			// pictureBox1
			// 
			this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Default;
			this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pictureBox1.Location = new System.Drawing.Point(0, 0);
			this.pictureBox1.Margin = new System.Windows.Forms.Padding(1, 3, 3, 3);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(767, 423);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 3;
			this.pictureBox1.TabStop = false;
			this.pictureBox1.Visible = false;
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.Ivory;
			this.panel1.Controls.Add(this.label1);
			this.panel1.Controls.Add(this.trackBar1);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
			this.panel1.Location = new System.Drawing.Point(767, 35);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(58, 423);
			this.panel1.TabIndex = 4;
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(6, 223);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(47, 19);
			this.label1.TabIndex = 1;
			this.label1.Text = "label1";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// trackBar1
			// 
			this.trackBar1.Enabled = false;
			this.trackBar1.Location = new System.Drawing.Point(8, 8);
			this.trackBar1.Maximum = 100;
			this.trackBar1.Minimum = -100;
			this.trackBar1.Name = "trackBar1";
			this.trackBar1.Orientation = System.Windows.Forms.Orientation.Vertical;
			this.trackBar1.Size = new System.Drawing.Size(45, 208);
			this.trackBar1.TabIndex = 0;
			this.trackBar1.TickFrequency = 5;
			this.trackBar1.TickStyle = System.Windows.Forms.TickStyle.Both;
			this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.pictureBox2);
			this.panel2.Controls.Add(this.pictureBox1);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel2.Location = new System.Drawing.Point(0, 35);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(767, 423);
			this.panel2.TabIndex = 6;
			// 
			// pictureBox2
			// 
			this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pictureBox2.Location = new System.Drawing.Point(0, 0);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(767, 423);
			this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox2.TabIndex = 4;
			this.pictureBox2.TabStop = false;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(825, 458);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.menuStrip1);
			this.Name = "Form1";
			this.Text = "Form1";
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
			this.panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TrackBar trackBar1;
		private System.Windows.Forms.ToolStripMenuItem brightnessToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem contrastToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem resizeToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem adaptiveSmoothingToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem sepiaToolStripMenuItem;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.ToolStripMenuItem originToolStripMenuItem;
		private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.ToolStripMenuItem convolutionToolStripMenuItem;
	}
}

