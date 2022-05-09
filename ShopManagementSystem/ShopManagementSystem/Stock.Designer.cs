namespace ShopManagementSystem
{
    partial class Stock
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
            this.richTextBoxShelfStock = new System.Windows.Forms.RichTextBox();
            this.richTextBoxStoreStock = new System.Windows.Forms.RichTextBox();
            this.btnListShelfStock = new System.Windows.Forms.Button();
            this.btnListStoreStock = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnProHomePage = new System.Windows.Forms.Button();
            this.btnProClose = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // richTextBoxShelfStock
            // 
            this.richTextBoxShelfStock.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.richTextBoxShelfStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.richTextBoxShelfStock.Location = new System.Drawing.Point(6, 54);
            this.richTextBoxShelfStock.Name = "richTextBoxShelfStock";
            this.richTextBoxShelfStock.Size = new System.Drawing.Size(297, 294);
            this.richTextBoxShelfStock.TabIndex = 0;
            this.richTextBoxShelfStock.Text = "";
            // 
            // richTextBoxStoreStock
            // 
            this.richTextBoxStoreStock.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.richTextBoxStoreStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.richTextBoxStoreStock.Location = new System.Drawing.Point(6, 54);
            this.richTextBoxStoreStock.Name = "richTextBoxStoreStock";
            this.richTextBoxStoreStock.Size = new System.Drawing.Size(306, 294);
            this.richTextBoxStoreStock.TabIndex = 1;
            this.richTextBoxStoreStock.Text = "";
            // 
            // btnListShelfStock
            // 
            this.btnListShelfStock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnListShelfStock.FlatAppearance.BorderColor = System.Drawing.Color.DarkRed;
            this.btnListShelfStock.FlatAppearance.BorderSize = 2;
            this.btnListShelfStock.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnListShelfStock.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnListShelfStock.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnListShelfStock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListShelfStock.Location = new System.Drawing.Point(74, 354);
            this.btnListShelfStock.Name = "btnListShelfStock";
            this.btnListShelfStock.Size = new System.Drawing.Size(150, 45);
            this.btnListShelfStock.TabIndex = 2;
            this.btnListShelfStock.Text = "Raf Stoğu Listele";
            this.btnListShelfStock.UseVisualStyleBackColor = false;
            this.btnListShelfStock.Click += new System.EventHandler(this.btnListShelfStock_Click);
            // 
            // btnListStoreStock
            // 
            this.btnListStoreStock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnListStoreStock.FlatAppearance.BorderColor = System.Drawing.Color.DarkRed;
            this.btnListStoreStock.FlatAppearance.BorderSize = 2;
            this.btnListStoreStock.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnListStoreStock.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnListStoreStock.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnListStoreStock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListStoreStock.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnListStoreStock.Location = new System.Drawing.Point(88, 354);
            this.btnListStoreStock.Name = "btnListStoreStock";
            this.btnListStoreStock.Size = new System.Drawing.Size(150, 45);
            this.btnListStoreStock.TabIndex = 3;
            this.btnListStoreStock.Text = "Depo Stoğu Listele";
            this.btnListStoreStock.UseVisualStyleBackColor = false;
            this.btnListStoreStock.Click += new System.EventHandler(this.btnListStoreStock_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.SandyBrown;
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.richTextBoxShelfStock);
            this.groupBox1.Controls.Add(this.btnListShelfStock);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(311, 405);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ürün Raf Stoğu";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(297, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "ÜrünNo/ÜrünAdı/ÜrünTipi/ÜrünÜcreti/RafStok";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.SandyBrown;
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.btnListStoreStock);
            this.groupBox2.Controls.Add(this.richTextBoxStoreStock);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.Location = new System.Drawing.Point(329, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(321, 405);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ürün Depo Stoğu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(309, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "ÜrünNo/ÜrünAdı/ÜrünTipi/ÜrünÜcreti/DepoStok";
            // 
            // btnProHomePage
            // 
            this.btnProHomePage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnProHomePage.FlatAppearance.BorderColor = System.Drawing.Color.Yellow;
            this.btnProHomePage.FlatAppearance.BorderSize = 2;
            this.btnProHomePage.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnProHomePage.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnProHomePage.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnProHomePage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProHomePage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnProHomePage.Location = new System.Drawing.Point(169, 446);
            this.btnProHomePage.Name = "btnProHomePage";
            this.btnProHomePage.Size = new System.Drawing.Size(146, 46);
            this.btnProHomePage.TabIndex = 18;
            this.btnProHomePage.Text = "Ana Sayfaya Dön";
            this.btnProHomePage.UseVisualStyleBackColor = false;
            this.btnProHomePage.Click += new System.EventHandler(this.btnProHomePage_Click);
            // 
            // btnProClose
            // 
            this.btnProClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnProClose.FlatAppearance.BorderColor = System.Drawing.Color.Yellow;
            this.btnProClose.FlatAppearance.BorderSize = 2;
            this.btnProClose.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnProClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnProClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnProClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnProClose.Location = new System.Drawing.Point(335, 446);
            this.btnProClose.Name = "btnProClose";
            this.btnProClose.Size = new System.Drawing.Size(146, 46);
            this.btnProClose.TabIndex = 19;
            this.btnProClose.Text = "Uygulamayı Kapat";
            this.btnProClose.UseVisualStyleBackColor = false;
            this.btnProClose.Click += new System.EventHandler(this.btnProClose_Click);
            // 
            // Stock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(661, 506);
            this.Controls.Add(this.btnProClose);
            this.Controls.Add(this.btnProHomePage);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Stock";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "STOK İŞLEMLERİ";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBoxShelfStock;
        private System.Windows.Forms.RichTextBox richTextBoxStoreStock;
        private System.Windows.Forms.Button btnListShelfStock;
        private System.Windows.Forms.Button btnListStoreStock;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnProHomePage;
        private System.Windows.Forms.Button btnProClose;
    }
}