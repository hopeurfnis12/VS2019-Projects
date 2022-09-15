
namespace NETLaba4
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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.развернутьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.сведенияОПреподавателяхToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.сведенияОСтудентахToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.свернутьВТрейToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.закрытьToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.выходToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.AutoSize = false;
			this.menuStrip1.BackColor = System.Drawing.Color.Khaki;
			this.menuStrip1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(0);
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.развернутьToolStripMenuItem,
            this.закрытьToolStripMenuItem1,
            this.выходToolStripMenuItem1});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
			this.menuStrip1.Size = new System.Drawing.Size(609, 36);
			this.menuStrip1.TabIndex = 1;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// развернутьToolStripMenuItem
			// 
			this.развернутьToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.сведенияОПреподавателяхToolStripMenuItem,
            this.сведенияОСтудентахToolStripMenuItem,
            this.свернутьВТрейToolStripMenuItem});
			this.развернутьToolStripMenuItem.Name = "развернутьToolStripMenuItem";
			this.развернутьToolStripMenuItem.Size = new System.Drawing.Size(93, 36);
			this.развернутьToolStripMenuItem.Text = "Развернуть";
			// 
			// сведенияОПреподавателяхToolStripMenuItem
			// 
			this.сведенияОПреподавателяхToolStripMenuItem.Name = "сведенияОПреподавателяхToolStripMenuItem";
			this.сведенияОПреподавателяхToolStripMenuItem.Size = new System.Drawing.Size(260, 22);
			this.сведенияОПреподавателяхToolStripMenuItem.Text = "Сведения о преподавателях";
			this.сведенияОПреподавателяхToolStripMenuItem.Click += new System.EventHandler(this.сведенияОПреподавателяхToolStripMenuItem_Click);
			// 
			// сведенияОСтудентахToolStripMenuItem
			// 
			this.сведенияОСтудентахToolStripMenuItem.Name = "сведенияОСтудентахToolStripMenuItem";
			this.сведенияОСтудентахToolStripMenuItem.Size = new System.Drawing.Size(260, 22);
			this.сведенияОСтудентахToolStripMenuItem.Text = "Сведения о студентах";
			this.сведенияОСтудентахToolStripMenuItem.Click += new System.EventHandler(this.сведенияОСтудентахToolStripMenuItem_Click);
			// 
			// свернутьВТрейToolStripMenuItem
			// 
			this.свернутьВТрейToolStripMenuItem.Name = "свернутьВТрейToolStripMenuItem";
			this.свернутьВТрейToolStripMenuItem.Size = new System.Drawing.Size(260, 22);
			this.свернутьВТрейToolStripMenuItem.Text = "Свернуть в трей";
			this.свернутьВТрейToolStripMenuItem.Click += new System.EventHandler(this.свернутьВТрейToolStripMenuItem_Click);
			// 
			// закрытьToolStripMenuItem1
			// 
			this.закрытьToolStripMenuItem1.ForeColor = System.Drawing.SystemColors.ControlText;
			this.закрытьToolStripMenuItem1.Name = "закрытьToolStripMenuItem1";
			this.закрытьToolStripMenuItem1.Size = new System.Drawing.Size(72, 36);
			this.закрытьToolStripMenuItem1.Text = "Закрыть";
			this.закрытьToolStripMenuItem1.Click += new System.EventHandler(this.закрытьToolStripMenuItem1_Click);
			// 
			// выходToolStripMenuItem1
			// 
			this.выходToolStripMenuItem1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
			this.выходToolStripMenuItem1.Name = "выходToolStripMenuItem1";
			this.выходToolStripMenuItem1.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.выходToolStripMenuItem1.Size = new System.Drawing.Size(59, 36);
			this.выходToolStripMenuItem1.Text = "Выход";
			this.выходToolStripMenuItem1.Click += new System.EventHandler(this.выходToolStripMenuItem1_Click);
			// 
			// contextMenuStrip1
			// 
			this.contextMenuStrip1.Name = "contextMenuStrip1";
			this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
			// 
			// contextMenuStrip2
			// 
			this.contextMenuStrip2.Name = "contextMenuStrip2";
			this.contextMenuStrip2.Size = new System.Drawing.Size(61, 4);
			// 
			// notifyIcon1
			// 
			this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
			this.notifyIcon1.Text = "notifyIcon1";
			this.notifyIcon1.Visible = true;
			this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Info;
			this.ClientSize = new System.Drawing.Size(609, 394);
			this.Controls.Add(this.menuStrip1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.IsMdiContainer = true;
			this.Name = "Form1";
			this.Text = "Приложение";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem развернутьToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem сведенияОПреподавателяхToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem сведенияОСтудентахToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem свернутьВТрейToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem закрытьToolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem1;
		private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
		private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
		private System.Windows.Forms.NotifyIcon notifyIcon1;
	}
}

