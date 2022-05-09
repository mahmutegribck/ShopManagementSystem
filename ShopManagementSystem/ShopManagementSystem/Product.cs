/****************************************************************************
**				    	SAKARYA ÜNİVERSİTESİ
**				BİLGİSAYAR VE BİLİŞİM BİLİMLERİ FAKÜLTESİ
**				    BİLGİSAYAR MÜHENDİSLİĞİ BÖLÜMÜ
**				   NESNEYE DAYALI PROGRAMLAMA DERSİ
**				    	2021-2022 BAHAR DÖNEMİ
**	
**				ÖDEV NUMARASI..........:1.Proje / Tasarım
**				ÖĞRENCİ ADI............:Mahmut Eğribacak
**				ÖĞRENCİ NUMARASI.......:B211210384
**              DERSİN ALINDIĞI GRUP...:1.Öğretim A Grubu
****************************************************************************/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShopManagementSystem
{
    public partial class Product : Form
    {
        ProductClass product = new ProductClass();
        public Product()
        {
            InitializeComponent();
        }

        private void listProduct_Click(object sender, EventArgs e)
        {
            //Ürün.txt dosyasının içeriğini richTextBox a yazdırılması sağlanır. 

            FileStream fsProduct = new FileStream(@"Ürün.txt", FileMode.Open);
            StreamReader streamReader = new StreamReader(fsProduct);
            richTextBoxProduct.Text = streamReader.ReadToEnd();
            streamReader.Close();
            fsProduct.Close();
        }

        private void deleteProduct_Click(object sender, EventArgs e)
        {
            //Ürün.txt dosyasından ürün silinmesi sağlanır.

            product.ProductNumber = int.Parse(txtDelProdNo.Text);
            File.WriteAllLines(@"Ürün.txt", File.ReadAllLines(@"Ürün.txt").Where(s => !s.StartsWith(product.ProductNumber + " ")));
        }

        private void productUpdate_Click(object sender, EventArgs e)
        {
            //Ürün.txt dosyasındaki ürünlerin güncellenmsi işlemleri yapılır.

            ProductClass productUpdate = new ProductClass();

            StreamReader streamReaderProduct = new StreamReader(@"Ürün.txt");

            string line, lineUpdateProduct;
            int i = 0;

            List<string> lines = new List<string>();

            while ((line = streamReaderProduct.ReadLine()) != null)
            {
                lines.Add(line);
            }
            streamReaderProduct.Close();

            foreach (string lineList in lines)
            {
                string[] parts = lineList.Split(' ');

                product.ProductNumber = int.Parse(parts[0]);
                if (product.ProductNumber == int.Parse(txtUpProductNum.Text))
                {

                    File.WriteAllLines(@"Ürün.txt", File.ReadAllLines(@"Ürün.txt").Where(s => !s.StartsWith(product.ProductNumber + " ")));

                    product.ProductName = txtNewProName.Text;
                    product.ProductType = txtNewProType.Text;
                    product.ProductPrice = int.Parse(txtNewProPrice.Text);
                    product.stock.ShelfStock = int.Parse(txtNewShelfStock.Text);
                    product.stock.StoreStock = int.Parse(txtNewStoreStock.Text);

                    FileStream fsProduct = new FileStream(@"Ürün.txt", FileMode.Append);
                    StreamWriter streamWriterProduct = new StreamWriter(fsProduct);

                    lineUpdateProduct = (product.ProductNumber + " " +
                                         product.ProductName + " " +
                                         product.ProductType + " " +
                                         product.ProductPrice + " " +
                                         product.stock.ShelfStock + " " +
                                         product.stock.StoreStock).ToString();

                    streamWriterProduct.Write(lineUpdateProduct);
                    streamWriterProduct.Flush();
                    streamWriterProduct.Close();
                    fsProduct.Close();
                    i++;
                }
            }
            if(i == 0)
            {
                MessageBox.Show("Güncellenecek Ürün Kaydı Bulunamadı");
            }
        }

        private void btnProHomePage_Click(object sender, EventArgs e)
        {
            Shope shope1 = new Shope();     //Shope sayfasına yönlendirilir.
            shope1.Show();
            this.Hide();
        }

        private void btnProClose_Click(object sender, EventArgs e)
        {
            Application.Exit();     //Uygulama kapatılır.
        }
    }
}
