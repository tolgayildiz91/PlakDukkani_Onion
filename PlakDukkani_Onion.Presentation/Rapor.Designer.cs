namespace PlakDukkani_Onion.Presentation
{
    partial class Rapor
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
            dgvAlbumRapor = new DataGridView();
            btnDiscontinued = new Button();
            btnContinued = new Button();
            btnLast10 = new Button();
            btnDiscount = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvAlbumRapor).BeginInit();
            SuspendLayout();
            // 
            // dgvAlbumRapor
            // 
            dgvAlbumRapor.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAlbumRapor.Location = new Point(11, 108);
            dgvAlbumRapor.Margin = new Padding(2);
            dgvAlbumRapor.Name = "dgvAlbumRapor";
            dgvAlbumRapor.RowHeadersWidth = 62;
            dgvAlbumRapor.RowTemplate.Height = 33;
            dgvAlbumRapor.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvAlbumRapor.Size = new Size(892, 248);
            dgvAlbumRapor.TabIndex = 74;
            // 
            // btnDiscontinued
            // 
            btnDiscontinued.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnDiscontinued.Location = new Point(11, 22);
            btnDiscontinued.Margin = new Padding(2);
            btnDiscontinued.Name = "btnDiscontinued";
            btnDiscontinued.Size = new Size(220, 69);
            btnDiscontinued.TabIndex = 75;
            btnDiscontinued.Text = "Discontinued";
            btnDiscontinued.UseVisualStyleBackColor = true;
            btnDiscontinued.Click += btnDiscontinued_Click;
            // 
            // btnContinued
            // 
            btnContinued.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnContinued.Location = new Point(235, 22);
            btnContinued.Margin = new Padding(2);
            btnContinued.Name = "btnContinued";
            btnContinued.Size = new Size(220, 69);
            btnContinued.TabIndex = 75;
            btnContinued.Text = "Continued";
            btnContinued.UseVisualStyleBackColor = true;
            btnContinued.Click += btnContinued_Click;
            // 
            // btnLast10
            // 
            btnLast10.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnLast10.Location = new Point(459, 22);
            btnLast10.Margin = new Padding(2);
            btnLast10.Name = "btnLast10";
            btnLast10.Size = new Size(220, 69);
            btnLast10.TabIndex = 75;
            btnLast10.Text = "Last 10";
            btnLast10.UseVisualStyleBackColor = true;
            btnLast10.Click += btnLast10_Click;
            // 
            // btnDiscount
            // 
            btnDiscount.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnDiscount.Location = new Point(683, 22);
            btnDiscount.Margin = new Padding(2);
            btnDiscount.Name = "btnDiscount";
            btnDiscount.Size = new Size(220, 69);
            btnDiscount.TabIndex = 75;
            btnDiscount.Text = "Discount";
            btnDiscount.UseVisualStyleBackColor = true;
            btnDiscount.Click += btnDiscount_Click;
            // 
            // Rapor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(911, 363);
            Controls.Add(btnDiscount);
            Controls.Add(btnLast10);
            Controls.Add(btnContinued);
            Controls.Add(btnDiscontinued);
            Controls.Add(dgvAlbumRapor);
            Name = "Rapor";
            Text = "Rapor";
            ((System.ComponentModel.ISupportInitialize)dgvAlbumRapor).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvAlbumRapor;
        private Button btnDiscontinued;
        private Button btnContinued;
        private Button btnLast10;
        private Button btnDiscount;
    }
}