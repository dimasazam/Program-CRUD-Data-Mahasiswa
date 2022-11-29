namespace Latihan04
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
			this.panel1 = new System.Windows.Forms.Panel();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.button2 = new System.Windows.Forms.Button();
			this.textBox4 = new System.Windows.Forms.TextBox();
			this.button4 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.dBAplikasiDataSet1 = new Latihan04.DBAplikasiDataSet1();
			this.tblmhsBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.tbl_mhsTableAdapter = new Latihan04.DBAplikasiDataSet1TableAdapters.tbl_mhsTableAdapter();
			this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.jurusanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dBAplikasiDataSet1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.tblmhsBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.SystemColors.InactiveCaption;
			this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel1.Controls.Add(this.dataGridView1);
			this.panel1.Controls.Add(this.textBox3);
			this.panel1.Controls.Add(this.button2);
			this.panel1.Controls.Add(this.textBox4);
			this.panel1.Controls.Add(this.button4);
			this.panel1.Controls.Add(this.button3);
			this.panel1.Controls.Add(this.button1);
			this.panel1.Controls.Add(this.label5);
			this.panel1.Controls.Add(this.label4);
			this.panel1.Controls.Add(this.textBox2);
			this.panel1.Controls.Add(this.label3);
			this.panel1.Controls.Add(this.textBox1);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Location = new System.Drawing.Point(12, 12);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(482, 359);
			this.panel1.TabIndex = 0;
			// 
			// dataGridView1
			// 
			this.dataGridView1.AutoGenerateColumns = false;
			this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.jurusanDataGridViewTextBoxColumn,
            this.dataGridViewTextBoxColumn3});
			this.dataGridView1.DataSource = this.tblmhsBindingSource;
			this.dataGridView1.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.dataGridView1.Location = new System.Drawing.Point(19, 195);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(445, 146);
			this.dataGridView1.TabIndex = 19;
			this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
			// 
			// textBox3
			// 
			this.textBox3.Location = new System.Drawing.Point(82, 155);
			this.textBox3.Name = "textBox3";
			this.textBox3.Size = new System.Drawing.Size(267, 20);
			this.textBox3.TabIndex = 18;
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(383, 96);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(81, 23);
			this.button2.TabIndex = 17;
			this.button2.Text = "Edit";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// textBox4
			// 
			this.textBox4.Location = new System.Drawing.Point(82, 128);
			this.textBox4.Name = "textBox4";
			this.textBox4.Size = new System.Drawing.Size(267, 20);
			this.textBox4.TabIndex = 16;
			// 
			// button4
			// 
			this.button4.Location = new System.Drawing.Point(383, 153);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(81, 23);
			this.button4.TabIndex = 15;
			this.button4.Text = "Lihat";
			this.button4.UseVisualStyleBackColor = true;
			this.button4.Click += new System.EventHandler(this.button4_Click);
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(383, 126);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(81, 23);
			this.button3.TabIndex = 13;
			this.button3.Text = "Hapus";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(383, 70);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(81, 23);
			this.button1.TabIndex = 11;
			this.button1.Text = "Tambah";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(24, 156);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(27, 13);
			this.label5.TabIndex = 8;
			this.label5.Text = "Asal";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(24, 129);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(44, 13);
			this.label4.TabIndex = 5;
			this.label4.Text = "Jurusan";
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(82, 98);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(267, 20);
			this.textBox2.TabIndex = 4;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(24, 99);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(35, 13);
			this.label3.TabIndex = 3;
			this.label3.Text = "Nama";
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(82, 72);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(267, 20);
			this.textBox1.TabIndex = 2;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(24, 73);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(29, 13);
			this.label2.TabIndex = 1;
			this.label2.Text = "Npm";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Montserrat", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(21, 14);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(338, 37);
			this.label1.TabIndex = 0;
			this.label1.Text = "Input Data Mahasiswa";
			// 
			// dBAplikasiDataSet1
			// 
			this.dBAplikasiDataSet1.DataSetName = "DBAplikasiDataSet1";
			this.dBAplikasiDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// tblmhsBindingSource
			// 
			this.tblmhsBindingSource.DataMember = "tbl_mhs";
			this.tblmhsBindingSource.DataSource = this.dBAplikasiDataSet1;
			// 
			// tbl_mhsTableAdapter
			// 
			this.tbl_mhsTableAdapter.ClearBeforeFill = true;
			// 
			// dataGridViewTextBoxColumn1
			// 
			this.dataGridViewTextBoxColumn1.DataPropertyName = "NPM";
			this.dataGridViewTextBoxColumn1.HeaderText = "NPM";
			this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
			this.dataGridViewTextBoxColumn1.Width = 80;
			// 
			// dataGridViewTextBoxColumn2
			// 
			this.dataGridViewTextBoxColumn2.DataPropertyName = "NamaMahasiswa";
			this.dataGridViewTextBoxColumn2.HeaderText = "Nama Mahasiswa";
			this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
			this.dataGridViewTextBoxColumn2.Width = 120;
			// 
			// jurusanDataGridViewTextBoxColumn
			// 
			this.jurusanDataGridViewTextBoxColumn.DataPropertyName = "Jurusan";
			this.jurusanDataGridViewTextBoxColumn.HeaderText = "Jurusan";
			this.jurusanDataGridViewTextBoxColumn.Name = "jurusanDataGridViewTextBoxColumn";
			// 
			// dataGridViewTextBoxColumn3
			// 
			this.dataGridViewTextBoxColumn3.DataPropertyName = "AsalKota";
			this.dataGridViewTextBoxColumn3.HeaderText = "Asal Kota";
			this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.ClientSize = new System.Drawing.Size(506, 385);
			this.Controls.Add(this.panel1);
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dBAplikasiDataSet1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.tblmhsBindingSource)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.TextBox textBox4;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.TextBox textBox3;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.DataGridViewTextBoxColumn npmDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn namaMahasiswaDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn asalKotaDataGridViewTextBoxColumn;
		private DBAplikasiDataSet1 dBAplikasiDataSet1;
		private System.Windows.Forms.BindingSource tblmhsBindingSource;
		private DBAplikasiDataSet1TableAdapters.tbl_mhsTableAdapter tbl_mhsTableAdapter;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
		private System.Windows.Forms.DataGridViewTextBoxColumn jurusanDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
	}
}

