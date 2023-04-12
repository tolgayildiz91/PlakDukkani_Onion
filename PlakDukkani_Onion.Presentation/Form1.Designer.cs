namespace PlakDukkani_Onion.Presentation
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
            label8 = new Label();
            rbBitti = new RadioButton();
            rbDevam = new RadioButton();
            groupBox1 = new GroupBox();
            dateTimePicker1 = new DateTimePicker();
            btnGuncelle = new Button();
            btnRapor = new Button();
            btnSil = new Button();
            btnEkle = new Button();
            dgvAlbum = new DataGridView();
            txtIndirim = new TextBox();
            txtPrice = new TextBox();
            txtSanatci = new TextBox();
            label5 = new Label();
            label4 = new Label();
            txtName = new TextBox();
            label3 = new Label();
            label1 = new Label();
            label2 = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAlbum).BeginInit();
            SuspendLayout();
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(19, 323);
            label8.Name = "label8";
            label8.Size = new Size(95, 21);
            label8.TabIndex = 73;
            label8.Text = "Album List:";
            // 
            // rbBitti
            // 
            rbBitti.AutoSize = true;
            rbBitti.Location = new Point(213, 26);
            rbBitti.Name = "rbBitti";
            rbBitti.Size = new Size(108, 21);
            rbBitti.TabIndex = 1;
            rbBitti.TabStop = true;
            rbBitti.Text = "Discontinued";
            rbBitti.UseVisualStyleBackColor = true;
            // 
            // rbDevam
            // 
            rbDevam.AutoSize = true;
            rbDevam.Location = new Point(66, 26);
            rbDevam.Name = "rbDevam";
            rbDevam.Size = new Size(82, 21);
            rbDevam.TabIndex = 0;
            rbDevam.TabStop = true;
            rbDevam.Text = "Continue";
            rbDevam.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rbBitti);
            groupBox1.Controls.Add(rbDevam);
            groupBox1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.Location = new Point(25, 245);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(509, 61);
            groupBox1.TabIndex = 68;
            groupBox1.TabStop = false;
            groupBox1.Text = "Sale Status:";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(108, 111);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(420, 23);
            dateTimePicker1.TabIndex = 67;
            // 
            // btnGuncelle
            // 
            btnGuncelle.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnGuncelle.Location = new Point(566, 100);
            btnGuncelle.Margin = new Padding(2);
            btnGuncelle.Name = "btnGuncelle";
            btnGuncelle.Size = new Size(220, 69);
            btnGuncelle.TabIndex = 66;
            btnGuncelle.Text = "UPDATE";
            btnGuncelle.UseVisualStyleBackColor = true;
            btnGuncelle.Click += btnGuncelle_Click;
            // 
            // btnRapor
            // 
            btnRapor.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnRapor.Location = new Point(566, 271);
            btnRapor.Margin = new Padding(2);
            btnRapor.Name = "btnRapor";
            btnRapor.Size = new Size(222, 69);
            btnRapor.TabIndex = 65;
            btnRapor.Text = "RAPOR";
            btnRapor.UseVisualStyleBackColor = true;
            btnRapor.Click += btnRapor_Click;
            // 
            // btnSil
            // 
            btnSil.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnSil.Location = new Point(566, 185);
            btnSil.Margin = new Padding(2);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(222, 69);
            btnSil.TabIndex = 64;
            btnSil.Text = "DELETE";
            btnSil.UseVisualStyleBackColor = true;
            btnSil.Click += btnSil_Click;
            // 
            // btnEkle
            // 
            btnEkle.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnEkle.Location = new Point(568, 16);
            btnEkle.Margin = new Padding(2);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(220, 69);
            btnEkle.TabIndex = 63;
            btnEkle.Text = "ADD";
            btnEkle.UseVisualStyleBackColor = true;
            btnEkle.Click += btnEkle_Click;
            // 
            // dgvAlbum
            // 
            dgvAlbum.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAlbum.Location = new Point(7, 363);
            dgvAlbum.Margin = new Padding(2);
            dgvAlbum.Name = "dgvAlbum";
            dgvAlbum.RowHeadersWidth = 62;
            dgvAlbum.RowTemplate.Height = 33;
            dgvAlbum.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvAlbum.Size = new Size(846, 248);
            dgvAlbum.TabIndex = 58;
            dgvAlbum.CellClick += dgvAlbum_CellClick;
            // 
            // txtIndirim
            // 
            txtIndirim.Location = new Point(108, 210);
            txtIndirim.Margin = new Padding(2);
            txtIndirim.Name = "txtIndirim";
            txtIndirim.Size = new Size(426, 23);
            txtIndirim.TabIndex = 57;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(108, 159);
            txtPrice.Margin = new Padding(2);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(426, 23);
            txtPrice.TabIndex = 56;
            // 
            // txtSanatci
            // 
            txtSanatci.Location = new Point(108, 64);
            txtSanatci.Margin = new Padding(2);
            txtSanatci.Name = "txtSanatci";
            txtSanatci.Size = new Size(426, 23);
            txtSanatci.TabIndex = 55;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(17, 208);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(82, 21);
            label5.TabIndex = 52;
            label5.Text = "Discount:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(17, 157);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(52, 21);
            label4.TabIndex = 51;
            label4.Text = "Price:";
            // 
            // txtName
            // 
            txtName.Location = new Point(108, 21);
            txtName.Margin = new Padding(2);
            txtName.Name = "txtName";
            txtName.Size = new Size(426, 23);
            txtName.TabIndex = 54;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(17, 111);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(50, 21);
            label3.TabIndex = 50;
            label3.Text = "Date:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(17, 62);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(83, 21);
            label1.TabIndex = 53;
            label1.Text = "Musician:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(17, 19);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(60, 21);
            label2.TabIndex = 49;
            label2.Text = "Name:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(864, 661);
            Controls.Add(label8);
            Controls.Add(groupBox1);
            Controls.Add(dateTimePicker1);
            Controls.Add(btnGuncelle);
            Controls.Add(btnRapor);
            Controls.Add(btnSil);
            Controls.Add(btnEkle);
            Controls.Add(dgvAlbum);
            Controls.Add(txtIndirim);
            Controls.Add(txtPrice);
            Controls.Add(txtSanatci);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(txtName);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(label2);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAlbum).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label8;
        private RadioButton rbBitti;
        private RadioButton rbDevam;
        private GroupBox groupBox1;
        private DateTimePicker dateTimePicker1;
        private Button btnGuncelle;
        private Button btnRapor;
        private Button btnSil;
        private Button btnEkle;
        private DataGridView dgvAlbum;
        private TextBox txtIndirim;
        private TextBox txtPrice;
        private TextBox txtSanatci;
        private Label label5;
        private Label label4;
        private TextBox txtName;
        private Label label3;
        private Label label1;
        private Label label2;
    }
}