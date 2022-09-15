namespace laba2
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
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.sbox = new System.Windows.Forms.TextBox();
			this.label11 = new System.Windows.Forms.Label();
			this.label12 = new System.Windows.Forms.Label();
			this.s1box = new System.Windows.Forms.TextBox();
			this.copiesn = new System.Windows.Forms.NumericUpDown();
			this.copiesbtn = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.button4 = new System.Windows.Forms.Button();
			this.button5 = new System.Windows.Forms.Button();
			this.button6 = new System.Windows.Forms.Button();
			this.button7 = new System.Windows.Forms.Button();
			this.button8 = new System.Windows.Forms.Button();
			this.button9 = new System.Windows.Forms.Button();
			this.button10 = new System.Windows.Forms.Button();
			this.copiesbox = new System.Windows.Forms.TextBox();
			this.wordsbox = new System.Windows.Forms.TextBox();
			this.parset = new System.Windows.Forms.TextBox();
			this.parsebox1 = new System.Windows.Forms.TextBox();
			this.parsebox2 = new System.Windows.Forms.TextBox();
			this.deletebox = new System.Windows.Forms.TextBox();
			this.insertbox = new System.Windows.Forms.TextBox();
			this.insertn = new System.Windows.Forms.NumericUpDown();
			this.deletel = new System.Windows.Forms.TextBox();
			this.deleten = new System.Windows.Forms.TextBox();
			this.reversebox = new System.Windows.Forms.TextBox();
			this.posbox = new System.Windows.Forms.TextBox();
			this.lastposbox = new System.Windows.Forms.TextBox();
			this.trimbox = new System.Windows.Forms.TextBox();
			this.wordbox = new System.Windows.Forms.TextBox();
			((System.ComponentModel.ISupportInitialize)(this.copiesn)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.insertn)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(21, 113);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(73, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Copies(s,s1,n)";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(196, 113);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(49, 13);
			this.label2.TabIndex = 1;
			this.label2.Text = "Words(s)";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(359, 113);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(51, 13);
			this.label3.TabIndex = 2;
			this.label3.Text = "Parse(s,t)";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(21, 263);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(63, 13);
			this.label4.TabIndex = 3;
			this.label4.Text = "Delete(s,n,l)";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(196, 263);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(67, 13);
			this.label5.TabIndex = 4;
			this.label5.Text = "Insert(s,s1,n)";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(359, 263);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(58, 13);
			this.label6.TabIndex = 5;
			this.label6.Text = "Reverse(s)";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(21, 404);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(50, 13);
			this.label7.TabIndex = 6;
			this.label7.Text = "Pos(s,s1)";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(196, 404);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(70, 13);
			this.label8.TabIndex = 7;
			this.label8.Text = "LastPos(s,s1)";
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(359, 404);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(38, 13);
			this.label9.TabIndex = 8;
			this.label9.Text = "Trim(s)";
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Location = new System.Drawing.Point(359, 21);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(44, 13);
			this.label10.TabIndex = 9;
			this.label10.Text = "Word(s)";
			// 
			// sbox
			// 
			this.sbox.Location = new System.Drawing.Point(24, 37);
			this.sbox.Name = "sbox";
			this.sbox.Size = new System.Drawing.Size(138, 20);
			this.sbox.TabIndex = 10;
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Location = new System.Drawing.Point(21, 21);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(12, 13);
			this.label11.TabIndex = 11;
			this.label11.Text = "s";
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.Location = new System.Drawing.Point(21, 65);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(18, 13);
			this.label12.TabIndex = 12;
			this.label12.Text = "s1";
			// 
			// s1box
			// 
			this.s1box.Location = new System.Drawing.Point(24, 81);
			this.s1box.Name = "s1box";
			this.s1box.Size = new System.Drawing.Size(138, 20);
			this.s1box.TabIndex = 13;
			// 
			// copiesn
			// 
			this.copiesn.Location = new System.Drawing.Point(24, 129);
			this.copiesn.Name = "copiesn";
			this.copiesn.Size = new System.Drawing.Size(49, 20);
			this.copiesn.TabIndex = 14;
			// 
			// copiesbtn
			// 
			this.copiesbtn.Location = new System.Drawing.Point(24, 181);
			this.copiesbtn.Name = "copiesbtn";
			this.copiesbtn.Size = new System.Drawing.Size(75, 23);
			this.copiesbtn.TabIndex = 17;
			this.copiesbtn.Text = "Copies";
			this.copiesbtn.UseVisualStyleBackColor = true;
			this.copiesbtn.Click += new System.EventHandler(this.copiesbtn_Click);
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(199, 153);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(75, 23);
			this.button2.TabIndex = 18;
			this.button2.Text = "Words";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(362, 206);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(75, 23);
			this.button3.TabIndex = 19;
			this.button3.Text = "Parse";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// button4
			// 
			this.button4.Location = new System.Drawing.Point(24, 357);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(75, 23);
			this.button4.TabIndex = 20;
			this.button4.Text = "Delete";
			this.button4.UseVisualStyleBackColor = true;
			this.button4.Click += new System.EventHandler(this.button4_Click);
			// 
			// button5
			// 
			this.button5.Location = new System.Drawing.Point(199, 331);
			this.button5.Name = "button5";
			this.button5.Size = new System.Drawing.Size(75, 23);
			this.button5.TabIndex = 21;
			this.button5.Text = "Insert";
			this.button5.UseVisualStyleBackColor = true;
			this.button5.Click += new System.EventHandler(this.button5_Click);
			// 
			// button6
			// 
			this.button6.Location = new System.Drawing.Point(362, 306);
			this.button6.Name = "button6";
			this.button6.Size = new System.Drawing.Size(75, 23);
			this.button6.TabIndex = 22;
			this.button6.Text = "Reverse";
			this.button6.UseVisualStyleBackColor = true;
			this.button6.Click += new System.EventHandler(this.button6_Click);
			// 
			// button7
			// 
			this.button7.Location = new System.Drawing.Point(24, 446);
			this.button7.Name = "button7";
			this.button7.Size = new System.Drawing.Size(75, 23);
			this.button7.TabIndex = 23;
			this.button7.Text = "Pos";
			this.button7.UseVisualStyleBackColor = true;
			this.button7.Click += new System.EventHandler(this.button7_Click);
			// 
			// button8
			// 
			this.button8.Location = new System.Drawing.Point(199, 446);
			this.button8.Name = "button8";
			this.button8.Size = new System.Drawing.Size(75, 23);
			this.button8.TabIndex = 24;
			this.button8.Text = "LastPos";
			this.button8.UseVisualStyleBackColor = true;
			this.button8.Click += new System.EventHandler(this.button8_Click);
			// 
			// button9
			// 
			this.button9.Location = new System.Drawing.Point(362, 446);
			this.button9.Name = "button9";
			this.button9.Size = new System.Drawing.Size(75, 23);
			this.button9.TabIndex = 25;
			this.button9.Text = "Trim";
			this.button9.UseVisualStyleBackColor = true;
			this.button9.Click += new System.EventHandler(this.button9_Click);
			// 
			// button10
			// 
			this.button10.Location = new System.Drawing.Point(362, 63);
			this.button10.Name = "button10";
			this.button10.Size = new System.Drawing.Size(75, 23);
			this.button10.TabIndex = 26;
			this.button10.Text = "Word";
			this.button10.UseVisualStyleBackColor = true;
			this.button10.Click += new System.EventHandler(this.button10_Click);
			// 
			// copiesbox
			// 
			this.copiesbox.Location = new System.Drawing.Point(24, 155);
			this.copiesbox.Name = "copiesbox";
			this.copiesbox.ReadOnly = true;
			this.copiesbox.Size = new System.Drawing.Size(138, 20);
			this.copiesbox.TabIndex = 27;
			// 
			// wordsbox
			// 
			this.wordsbox.Location = new System.Drawing.Point(199, 129);
			this.wordsbox.Name = "wordsbox";
			this.wordsbox.ReadOnly = true;
			this.wordsbox.Size = new System.Drawing.Size(100, 20);
			this.wordsbox.TabIndex = 28;
			// 
			// parset
			// 
			this.parset.Location = new System.Drawing.Point(362, 128);
			this.parset.Name = "parset";
			this.parset.Size = new System.Drawing.Size(48, 20);
			this.parset.TabIndex = 29;
			// 
			// parsebox1
			// 
			this.parsebox1.Location = new System.Drawing.Point(362, 154);
			this.parsebox1.Name = "parsebox1";
			this.parsebox1.ReadOnly = true;
			this.parsebox1.Size = new System.Drawing.Size(138, 20);
			this.parsebox1.TabIndex = 30;
			// 
			// parsebox2
			// 
			this.parsebox2.Location = new System.Drawing.Point(362, 180);
			this.parsebox2.Name = "parsebox2";
			this.parsebox2.ReadOnly = true;
			this.parsebox2.Size = new System.Drawing.Size(138, 20);
			this.parsebox2.TabIndex = 31;
			// 
			// deletebox
			// 
			this.deletebox.Location = new System.Drawing.Point(24, 331);
			this.deletebox.Name = "deletebox";
			this.deletebox.ReadOnly = true;
			this.deletebox.Size = new System.Drawing.Size(138, 20);
			this.deletebox.TabIndex = 34;
			// 
			// insertbox
			// 
			this.insertbox.Location = new System.Drawing.Point(199, 305);
			this.insertbox.Name = "insertbox";
			this.insertbox.ReadOnly = true;
			this.insertbox.Size = new System.Drawing.Size(138, 20);
			this.insertbox.TabIndex = 36;
			// 
			// insertn
			// 
			this.insertn.Location = new System.Drawing.Point(199, 280);
			this.insertn.Name = "insertn";
			this.insertn.Size = new System.Drawing.Size(49, 20);
			this.insertn.TabIndex = 37;
			// 
			// deletel
			// 
			this.deletel.Location = new System.Drawing.Point(24, 305);
			this.deletel.Name = "deletel";
			this.deletel.Size = new System.Drawing.Size(138, 20);
			this.deletel.TabIndex = 33;
			// 
			// deleten
			// 
			this.deleten.Location = new System.Drawing.Point(24, 279);
			this.deleten.Name = "deleten";
			this.deleten.Size = new System.Drawing.Size(138, 20);
			this.deleten.TabIndex = 32;
			// 
			// reversebox
			// 
			this.reversebox.Location = new System.Drawing.Point(362, 280);
			this.reversebox.Name = "reversebox";
			this.reversebox.ReadOnly = true;
			this.reversebox.Size = new System.Drawing.Size(138, 20);
			this.reversebox.TabIndex = 38;
			// 
			// posbox
			// 
			this.posbox.Location = new System.Drawing.Point(24, 420);
			this.posbox.Name = "posbox";
			this.posbox.ReadOnly = true;
			this.posbox.Size = new System.Drawing.Size(138, 20);
			this.posbox.TabIndex = 39;
			// 
			// lastposbox
			// 
			this.lastposbox.Location = new System.Drawing.Point(199, 420);
			this.lastposbox.Name = "lastposbox";
			this.lastposbox.ReadOnly = true;
			this.lastposbox.Size = new System.Drawing.Size(138, 20);
			this.lastposbox.TabIndex = 40;
			// 
			// trimbox
			// 
			this.trimbox.Location = new System.Drawing.Point(362, 420);
			this.trimbox.Name = "trimbox";
			this.trimbox.ReadOnly = true;
			this.trimbox.Size = new System.Drawing.Size(138, 20);
			this.trimbox.TabIndex = 41;
			// 
			// wordbox
			// 
			this.wordbox.Location = new System.Drawing.Point(362, 37);
			this.wordbox.Name = "wordbox";
			this.wordbox.ReadOnly = true;
			this.wordbox.Size = new System.Drawing.Size(138, 20);
			this.wordbox.TabIndex = 42;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(720, 559);
			this.Controls.Add(this.wordbox);
			this.Controls.Add(this.trimbox);
			this.Controls.Add(this.lastposbox);
			this.Controls.Add(this.posbox);
			this.Controls.Add(this.reversebox);
			this.Controls.Add(this.insertn);
			this.Controls.Add(this.insertbox);
			this.Controls.Add(this.deletebox);
			this.Controls.Add(this.deletel);
			this.Controls.Add(this.deleten);
			this.Controls.Add(this.parsebox2);
			this.Controls.Add(this.parsebox1);
			this.Controls.Add(this.parset);
			this.Controls.Add(this.wordsbox);
			this.Controls.Add(this.copiesbox);
			this.Controls.Add(this.button10);
			this.Controls.Add(this.button9);
			this.Controls.Add(this.button8);
			this.Controls.Add(this.button7);
			this.Controls.Add(this.button6);
			this.Controls.Add(this.button5);
			this.Controls.Add(this.button4);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.copiesbtn);
			this.Controls.Add(this.copiesn);
			this.Controls.Add(this.s1box);
			this.Controls.Add(this.label12);
			this.Controls.Add(this.label11);
			this.Controls.Add(this.sbox);
			this.Controls.Add(this.label10);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "Form1";
			this.Text = "Form1";
			((System.ComponentModel.ISupportInitialize)(this.copiesn)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.insertn)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.TextBox sbox;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.TextBox s1box;
		private System.Windows.Forms.NumericUpDown copiesn;
		private System.Windows.Forms.Button copiesbtn;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.Button button5;
		private System.Windows.Forms.Button button6;
		private System.Windows.Forms.Button button7;
		private System.Windows.Forms.Button button8;
		private System.Windows.Forms.Button button9;
		private System.Windows.Forms.Button button10;
		private System.Windows.Forms.TextBox copiesbox;
		private System.Windows.Forms.TextBox wordsbox;
		private System.Windows.Forms.TextBox parset;
		private System.Windows.Forms.TextBox parsebox1;
		private System.Windows.Forms.TextBox parsebox2;
		private System.Windows.Forms.TextBox deletebox;
		private System.Windows.Forms.TextBox insertbox;
		private System.Windows.Forms.NumericUpDown insertn;
		private System.Windows.Forms.TextBox deletel;
		private System.Windows.Forms.TextBox deleten;
		private System.Windows.Forms.TextBox reversebox;
		private System.Windows.Forms.TextBox posbox;
		private System.Windows.Forms.TextBox lastposbox;
		private System.Windows.Forms.TextBox trimbox;
		private System.Windows.Forms.TextBox wordbox;
	}
}

