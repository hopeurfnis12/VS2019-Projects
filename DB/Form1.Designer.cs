namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.mainBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.бДDataSet = new WindowsFormsApp1.БДDataSet();
            this.mainTableAdapter = new WindowsFormsApp1.БДDataSetTableAdapters.mainTableAdapter();
            this.tableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableTableAdapter = new WindowsFormsApp1.БДDataSetTableAdapters.tableTableAdapter();
            this.maintableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.maintableBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.mainBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.Pacient = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Diagnos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Data = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.бДDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maintableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maintableBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(734, 34);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(139, 43);
            this.button1.TabIndex = 1;
            this.button1.Text = "Добавить запись";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(734, 104);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(139, 43);
            this.button2.TabIndex = 2;
            this.button2.Text = "Удалить запись";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(734, 176);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(139, 43);
            this.button3.TabIndex = 3;
            this.button3.Text = "Найти запись";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(734, 244);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(139, 43);
            this.button4.TabIndex = 4;
            this.button4.Text = "Редактировать запись";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Pacient,
            this.Diagnos,
            this.Data});
            this.dataGridView1.DataSource = this.mainBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(13, 13);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(693, 302);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // mainBindingSource
            // 
            this.mainBindingSource.DataMember = "main";
            this.mainBindingSource.DataSource = this.бДDataSet;
            // 
            // бДDataSet
            // 
            this.бДDataSet.DataSetName = "БДDataSet";
            this.бДDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // mainTableAdapter
            // 
            this.mainTableAdapter.ClearBeforeFill = true;
            // 
            // tableBindingSource
            // 
            this.tableBindingSource.DataMember = "table";
            this.tableBindingSource.DataSource = this.бДDataSet;
            // 
            // tableTableAdapter
            // 
            this.tableTableAdapter.ClearBeforeFill = true;
            // 
            // maintableBindingSource
            // 
            this.maintableBindingSource.DataMember = "maintable";
            this.maintableBindingSource.DataSource = this.mainBindingSource;
            // 
            // maintableBindingSource1
            // 
            this.maintableBindingSource1.DataMember = "maintable";
            this.maintableBindingSource1.DataSource = this.mainBindingSource;
            // 
            // mainBindingSource1
            // 
            this.mainBindingSource1.DataMember = "main";
            this.mainBindingSource1.DataSource = this.бДDataSet;
            // 
            // Pacient
            // 
            this.Pacient.DataPropertyName = "Пациент";
            this.Pacient.HeaderText = "Пациент";
            this.Pacient.Name = "Pacient";
            this.Pacient.ReadOnly = true;
            this.Pacient.Width = 300;
            // 
            // Diagnos
            // 
            this.Diagnos.DataPropertyName = "Диагноз";
            this.Diagnos.HeaderText = "Диагноз";
            this.Diagnos.Name = "Diagnos";
            this.Diagnos.ReadOnly = true;
            this.Diagnos.Width = 200;
            // 
            // Data
            // 
            this.Data.DataPropertyName = "Дата";
            this.Data.HeaderText = "Дата";
            this.Data.Name = "Data";
            this.Data.ReadOnly = true;
            this.Data.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Data.Width = 150;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(894, 327);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "by Ayhal";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.бДDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maintableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maintableBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private БДDataSet бДDataSet;
        private System.Windows.Forms.BindingSource mainBindingSource;
        private БДDataSetTableAdapters.mainTableAdapter mainTableAdapter;
        private System.Windows.Forms.BindingSource tableBindingSource;
        private БДDataSetTableAdapters.tableTableAdapter tableTableAdapter;
        private System.Windows.Forms.BindingSource mainBindingSource1;
        private System.Windows.Forms.BindingSource maintableBindingSource;
        private System.Windows.Forms.BindingSource maintableBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pacient;
        private System.Windows.Forms.DataGridViewTextBoxColumn Diagnos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Data;
    }
}

