namespace ShopManagementSystem
{
    partial class Product
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
            this.listProduct = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.richTextBoxProduct = new System.Windows.Forms.RichTextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDelProdNo = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.productUpdate = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtNewStoreStock = new System.Windows.Forms.TextBox();
            this.txtNewShelfStock = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtNewProPrice = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.txtNewProType = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.txtNewProName = new System.Windows.Forms.TextBox();
            this.txtUpProductNum = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.deleteProduct = new System.Windows.Forms.Button();
            this.btnProClose = new System.Windows.Forms.Button();
            this.btnProHomePage = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listProduct
            // 
            this.listProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.listProduct.FlatAppearance.BorderColor = System.Drawing.Color.DarkRed;
            this.listProduct.FlatAppearance.BorderSize = 2;
            this.listProduct.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.listProduct.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.listProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.listProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.listProduct.Location = new System.Drawing.Point(85, 455);
            this.listProduct.Name = "listProduct";
            this.listProduct.Size = new System.Drawing.Size(146, 38);
            this.listProduct.TabIndex = 16;
            this.listProduct.Text = "Ürün Listele";
            this.listProduct.UseVisualStyleBackColor = false;
            this.listProduct.Click += new System.EventHandler(this.listProduct_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(20, 66);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 16);
            this.label8.TabIndex = 21;
            this.label8.Text = "Ürün No :";
            // 
            // richTextBoxProduct
            // 
            this.richTextBoxProduct.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.richTextBoxProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.richTextBoxProduct.Location = new System.Drawing.Point(6, 35);
            this.richTextBoxProduct.Name = "richTextBoxProduct";
            this.richTextBoxProduct.Size = new System.Drawing.Size(312, 414);
            this.richTextBoxProduct.TabIndex = 7;
            this.richTextBoxProduct.Text = "";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.SandyBrown;
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.listProduct);
            this.groupBox2.Controls.Add(this.richTextBoxProduct);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.ForeColor = System.Drawing.Color.Black;
            this.groupBox2.Location = new System.Drawing.Point(253, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(329, 499);
            this.groupBox2.TabIndex = 35;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ürün Listesi";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(6, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(312, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "ÜrünNo/ÜrünAdı/ÜrünTipi/ÜrünÜcreti/RafStok/DepoStok";
            // 
            // txtDelProdNo
            // 
            this.txtDelProdNo.Location = new System.Drawing.Point(97, 63);
            this.txtDelProdNo.Name = "txtDelProdNo";
            this.txtDelProdNo.Size = new System.Drawing.Size(100, 22);
            this.txtDelProdNo.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(38, 34);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(146, 16);
            this.label6.TabIndex = 12;
            this.label6.Text = "Güncellenecek Ürün";
            // 
            // productUpdate
            // 
            this.productUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.productUpdate.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.productUpdate.FlatAppearance.BorderSize = 2;
            this.productUpdate.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.productUpdate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.productUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.productUpdate.Location = new System.Drawing.Point(41, 282);
            this.productUpdate.Name = "productUpdate";
            this.productUpdate.Size = new System.Drawing.Size(146, 38);
            this.productUpdate.TabIndex = 15;
            this.productUpdate.Text = "Ürün Güncelle";
            this.productUpdate.UseVisualStyleBackColor = false;
            this.productUpdate.Click += new System.EventHandler(this.productUpdate_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(63, 89);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(131, 16);
            this.label7.TabIndex = 17;
            this.label7.Text = "Ürün Yeni Bilgileri";
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.SandyBrown;
            this.groupBox4.Controls.Add(this.txtNewStoreStock);
            this.groupBox4.Controls.Add(this.txtNewShelfStock);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.txtNewProPrice);
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Controls.Add(this.label19);
            this.groupBox4.Controls.Add(this.txtNewProType);
            this.groupBox4.Controls.Add(this.label21);
            this.groupBox4.Controls.Add(this.txtNewProName);
            this.groupBox4.Controls.Add(this.txtUpProductNum);
            this.groupBox4.Controls.Add(this.label17);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.productUpdate);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox4.Location = new System.Drawing.Point(14, 13);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(233, 332);
            this.groupBox4.TabIndex = 37;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Ürün Güncelle";
            // 
            // txtNewStoreStock
            // 
            this.txtNewStoreStock.Location = new System.Drawing.Point(101, 227);
            this.txtNewStoreStock.Name = "txtNewStoreStock";
            this.txtNewStoreStock.Size = new System.Drawing.Size(100, 22);
            this.txtNewStoreStock.TabIndex = 14;
            // 
            // txtNewShelfStock
            // 
            this.txtNewShelfStock.Location = new System.Drawing.Point(101, 200);
            this.txtNewShelfStock.Name = "txtNewShelfStock";
            this.txtNewShelfStock.Size = new System.Drawing.Size(100, 22);
            this.txtNewShelfStock.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 230);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 16);
            this.label3.TabIndex = 53;
            this.label3.Text = "Depo Stok :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(21, 203);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(74, 16);
            this.label9.TabIndex = 52;
            this.label9.Text = "Raf Stok :";
            // 
            // txtNewProPrice
            // 
            this.txtNewProPrice.Location = new System.Drawing.Point(101, 174);
            this.txtNewProPrice.Name = "txtNewProPrice";
            this.txtNewProPrice.Size = new System.Drawing.Size(100, 22);
            this.txtNewProPrice.TabIndex = 12;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 177);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(89, 16);
            this.label12.TabIndex = 50;
            this.label12.Text = "Ürün Fiyatı :";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(13, 149);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(82, 16);
            this.label19.TabIndex = 49;
            this.label19.Text = "Ürün Türü :";
            // 
            // txtNewProType
            // 
            this.txtNewProType.Location = new System.Drawing.Point(101, 146);
            this.txtNewProType.Name = "txtNewProType";
            this.txtNewProType.Size = new System.Drawing.Size(100, 22);
            this.txtNewProType.TabIndex = 11;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(21, 123);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(74, 16);
            this.label21.TabIndex = 45;
            this.label21.Text = "Ürün Adı :";
            // 
            // txtNewProName
            // 
            this.txtNewProName.Location = new System.Drawing.Point(101, 120);
            this.txtNewProName.Name = "txtNewProName";
            this.txtNewProName.Size = new System.Drawing.Size(100, 22);
            this.txtNewProName.TabIndex = 10;
            // 
            // txtUpProductNum
            // 
            this.txtUpProductNum.Location = new System.Drawing.Point(101, 58);
            this.txtUpProductNum.Name = "txtUpProductNum";
            this.txtUpProductNum.Size = new System.Drawing.Size(100, 22);
            this.txtUpProductNum.TabIndex = 9;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(24, 61);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(71, 16);
            this.label17.TabIndex = 32;
            this.label17.Text = "Ürün No :";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.SandyBrown;
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtDelProdNo);
            this.groupBox1.Controls.Add(this.deleteProduct);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(14, 351);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(233, 161);
            this.groupBox1.TabIndex = 34;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ürün Sil";
            // 
            // deleteProduct
            // 
            this.deleteProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.deleteProduct.FlatAppearance.BorderColor = System.Drawing.Color.DarkRed;
            this.deleteProduct.FlatAppearance.BorderSize = 2;
            this.deleteProduct.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.deleteProduct.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.deleteProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteProduct.Location = new System.Drawing.Point(66, 112);
            this.deleteProduct.Name = "deleteProduct";
            this.deleteProduct.Size = new System.Drawing.Size(95, 34);
            this.deleteProduct.TabIndex = 8;
            this.deleteProduct.Text = "Ürün Sil";
            this.deleteProduct.UseVisualStyleBackColor = false;
            this.deleteProduct.Click += new System.EventHandler(this.deleteProduct_Click);
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
            this.btnProClose.Location = new System.Drawing.Point(310, 532);
            this.btnProClose.Name = "btnProClose";
            this.btnProClose.Size = new System.Drawing.Size(146, 46);
            this.btnProClose.TabIndex = 18;
            this.btnProClose.Text = "Uygulamayı Kapat";
            this.btnProClose.UseVisualStyleBackColor = false;
            this.btnProClose.Click += new System.EventHandler(this.btnProClose_Click);
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
            this.btnProHomePage.Location = new System.Drawing.Point(101, 532);
            this.btnProHomePage.Name = "btnProHomePage";
            this.btnProHomePage.Size = new System.Drawing.Size(146, 46);
            this.btnProHomePage.TabIndex = 17;
            this.btnProHomePage.Text = "Ana Sayfaya Dön";
            this.btnProHomePage.UseVisualStyleBackColor = false;
            this.btnProHomePage.Click += new System.EventHandler(this.btnProHomePage_Click);
            // 
            // Product
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(592, 595);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnProClose);
            this.Controls.Add(this.btnProHomePage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MinimizeBox = false;
            this.Name = "Product";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ÜRÜN İŞLEMLERİ";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button listProduct;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RichTextBox richTextBoxProduct;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtDelProdNo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button productUpdate;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button deleteProduct;
        private System.Windows.Forms.Button btnProClose;
        private System.Windows.Forms.Button btnProHomePage;
        private System.Windows.Forms.TextBox txtNewShelfStock;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtNewProPrice;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox txtNewProType;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox txtNewProName;
        private System.Windows.Forms.TextBox txtUpProductNum;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtNewStoreStock;
        private System.Windows.Forms.Label label4;
    }
}