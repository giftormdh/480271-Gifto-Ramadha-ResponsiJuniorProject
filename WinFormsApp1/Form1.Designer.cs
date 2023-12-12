namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnInsert = new Button();
            btnEdit = new Button();
            btnDelete = new Button();
            dataGridView1 = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            txtNama = new TextBox();
            txtDep = new TextBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            pictureBox1 = new PictureBox();
            lblLogo = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnInsert
            // 
            btnInsert.Location = new Point(95, 152);
            btnInsert.Name = "btnInsert";
            btnInsert.Size = new Size(75, 23);
            btnInsert.TabIndex = 0;
            btnInsert.Text = "Insert";
            btnInsert.UseVisualStyleBackColor = true;
            btnInsert.Click += btnInsert_Click;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(218, 152);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(75, 23);
            btnEdit.TabIndex = 1;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(354, 152);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 23);
            btnDelete.TabIndex = 2;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(53, 211);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(443, 203);
            dataGridView1.TabIndex = 3;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(35, 64);
            label1.Name = "label1";
            label1.Size = new Size(102, 15);
            label1.TabIndex = 4;
            label1.Text = "Nama Karyawan : ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(43, 100);
            label2.Name = "label2";
            label2.Size = new Size(94, 15);
            label2.TabIndex = 5;
            label2.Text = "Dep. Karyawan : ";
            // 
            // txtNama
            // 
            txtNama.Location = new Point(154, 61);
            txtNama.Name = "txtNama";
            txtNama.Size = new Size(161, 23);
            txtNama.TabIndex = 6;
            txtNama.TextChanged += txtNama_TextChanged;
            // 
            // txtDep
            // 
            txtDep.AllowDrop = true;
            txtDep.Location = new Point(154, 97);
            txtDep.Name = "txtDep";
            txtDep.Size = new Size(161, 23);
            txtDep.TabIndex = 7;
            txtDep.TextChanged += txtDep_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(401, 9);
            label3.Name = "label3";
            label3.Size = new Size(95, 15);
            label3.TabIndex = 8;
            label3.Text = "ID Departemen : ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(401, 24);
            label4.Name = "label4";
            label4.Size = new Size(48, 15);
            label4.TabIndex = 9;
            label4.Text = "HR : HR";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(401, 39);
            label5.Name = "label5";
            label5.Size = new Size(85, 15);
            label5.TabIndex = 10;
            label5.Text = "ENG : Engineer";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(401, 54);
            label6.Name = "label6";
            label6.Size = new Size(90, 15);
            label6.TabIndex = 11;
            label6.Text = "DEV : Developer";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(401, 69);
            label7.Name = "label7";
            label7.Size = new Size(109, 15);
            label7.TabIndex = 12;
            label7.Text = "PM : Prod Manager";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(401, 84);
            label8.Name = "label8";
            label8.Size = new Size(75, 15);
            label8.TabIndex = 13;
            label8.Text = "FIN : Finance";
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(37, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(53, 50);
            pictureBox1.TabIndex = 14;
            pictureBox1.TabStop = false;
            // 
            // lblLogo
            // 
            lblLogo.AutoSize = true;
            lblLogo.ForeColor = Color.Black;
            lblLogo.Location = new Point(111, 25);
            lblLogo.Name = "lblLogo";
            lblLogo.Size = new Size(34, 15);
            lblLogo.TabIndex = 15;
            lblLogo.Text = "Logo";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(558, 450);
            Controls.Add(lblLogo);
            Controls.Add(pictureBox1);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(txtDep);
            Controls.Add(txtNama);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Controls.Add(btnDelete);
            Controls.Add(btnEdit);
            Controls.Add(btnInsert);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnInsert;
        private Button btnEdit;
        private Button btnDelete;
        private DataGridView dataGridView1;
        private Label label1;
        private Label label2;
        private TextBox txtNama;
        private TextBox txtDep;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private PictureBox pictureBox1;
        private Label lblLogo;
    }
}