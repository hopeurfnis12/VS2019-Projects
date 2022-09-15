
namespace NETLaba6
{
	partial class Main
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
			this.listBox1 = new System.Windows.Forms.ListBox();
			this.button1 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// listBox1
			// 
			this.listBox1.BackColor = System.Drawing.Color.Linen;
			this.listBox1.Cursor = System.Windows.Forms.Cursors.Hand;
			this.listBox1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.listBox1.ForeColor = System.Drawing.SystemColors.MenuText;
			this.listBox1.FormattingEnabled = true;
			this.listBox1.IntegralHeight = false;
			this.listBox1.ItemHeight = 22;
			this.listBox1.Items.AddRange(new object[] {
            "Винсент Ван Гог",
            "Клод Моне",
            "Леонардо да Винчи",
            "Пабло Пикассо",
            "Пьер Огюст Ренуар"});
			this.listBox1.Location = new System.Drawing.Point(29, 19);
			this.listBox1.Margin = new System.Windows.Forms.Padding(20, 10, 20, 20);
			this.listBox1.Name = "listBox1";
			this.listBox1.Size = new System.Drawing.Size(476, 202);
			this.listBox1.Sorted = true;
			this.listBox1.TabIndex = 0;
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.Color.White;
			this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.button1.Cursor = System.Windows.Forms.Cursors.Default;
			this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Olive;
			this.button1.FlatAppearance.BorderSize = 0;
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.button1.Font = new System.Drawing.Font("Samsung Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button1.ForeColor = System.Drawing.SystemColors.InfoText;
			this.button1.Location = new System.Drawing.Point(189, 240);
			this.button1.Margin = new System.Windows.Forms.Padding(180);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(156, 32);
			this.button1.TabIndex = 1;
			this.button1.Text = "Посмотреть";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// Main
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(534, 292);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.listBox1);
			this.Name = "Main";
			this.Text = "Главная";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Main_FormClosed);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.ListBox listBox1;
		private System.Windows.Forms.Button button1;
	}
}

