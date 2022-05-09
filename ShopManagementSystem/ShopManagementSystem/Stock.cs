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
    public partial class Stock : Form
    {

        public Stock()
        {
            InitializeComponent();
        }

        public void StockList(int option)
        {
            //Ürün.txt dosyasındaki ürün kayıtlarının raf ve depo stoklarının listelenmesi sağlanır.

            ProductClass product = new ProductClass();
            StreamReader sr = new StreamReader(@"Ürün.txt");
            string satir;
            while ((satir = sr.ReadLine()) != null)
            {
                string[] parcalar = satir.Split(' ');
                product.ProductNumber = int.Parse(parcalar[0]);
                product.ProductName = parcalar[1];
                product.ProductType = parcalar[2];
                product.ProductPrice = double.Parse(parcalar[3]);
                product.stock.ShelfStock = int.Parse(parcalar[4]);
                product.stock.StoreStock = int.Parse(parcalar[5]);

                if (option == 1)
                {
                    richTextBoxShelfStock.Text += product.ProductNumber + " " + product.ProductName + " " + product.ProductType + " " + product.ProductPrice + " " + product.stock.ShelfStock + '\n';
                    continue;
                }
                if (option == 0)
                {
                    richTextBoxStoreStock.Text += product.ProductNumber + " " + product.ProductName + " " + product.ProductType + " " + product.ProductPrice + " " + product.stock.StoreStock + '\n';
                    continue;
                }
            }
        }

        private void btnListShelfStock_Click(object sender, EventArgs e)
        {
            //Fonksiyon kullanılarak ürünlerin raf stokları richTextBox a yazdırılır.

            int option = 1;
            StockList(option);

        }

        private void btnListStoreStock_Click(object sender, EventArgs e)
        {
            //Fonksiyon kullanılarak ürünlerin depo stokları richTextBox a yazdırılır.
            int option = 0;
            StockList(option);
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
