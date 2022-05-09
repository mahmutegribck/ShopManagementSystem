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
    public partial class Sales : Form
    {
        OrderClass order = new OrderClass();
        public Sales()
        {
            InitializeComponent();
        }

        private void btnDeleteSales_Click(object sender, EventArgs e)
        {
            //Satış.txt dosyasındaki satış kaydı silinir ve Ürün.txt dosyasındaki ürün miktarı güncellenir.

            order.OrderNum = int.Parse(txtDelSalesNo.Text);
            StreamReader srSales = new StreamReader(@"Satış.txt");
            string line;
            int stockUpdate = 0;

            List<string> lines = new List<string>();
            while ((line = srSales.ReadLine()) != null)
            {
                lines.Add(line);
            }
            srSales.Close();
            foreach (string lineList in lines)
            {
                string[] parts = lineList.Split(' ');

                if (order.OrderNum == int.Parse(parts[0]))
                {
                    order.OrderQuantity = int.Parse(parts[1]);
                    stockUpdate = order.OrderQuantity;
                }
            }
            File.WriteAllLines(@"Satış.txt", File.ReadAllLines(@"Satış.txt").Where(s => !s.StartsWith(order.OrderNum + " ")));


            order.product.ProductNumber = int.Parse(txtDelProductNo.Text);

            StreamReader srProduct = new StreamReader(@"Ürün.txt");
            string lineProduct, lineUpdateProduct;

            List<string> linesProduct = new List<string>();
            while ((lineProduct = srProduct.ReadLine()) != null)
            {
                linesProduct.Add(lineProduct);
            }
            srProduct.Close();
            foreach (string lineListProduct in linesProduct)
            {
                string[] partsProduct = lineListProduct.Split(' ');

                if (order.product.ProductNumber == int.Parse(partsProduct[0]))
                {
                    File.WriteAllLines(@"Ürün.txt", File.ReadAllLines(@"Ürün.txt").Where(s => !s.StartsWith(order.product.ProductNumber + " ")));

                    order.product.ProductNumber = int.Parse(partsProduct[0]);
                    order.product.ProductName = partsProduct[1];
                    order.product.ProductType = partsProduct[2];
                    order.product.ProductPrice = double.Parse(partsProduct[3]);
                    order.product.stock.ShelfStock = int.Parse(partsProduct[4]);
                    order.product.stock.StoreStock = int.Parse(partsProduct[5]);
                    order.product.stock.StoreStock += stockUpdate;

                    lineUpdateProduct = (order.product.ProductNumber + " " +
                                         order.product.ProductName + " " +
                                         order.product.ProductType + " " +
                                         order.product.ProductPrice + " " +
                                         order.product.stock.ShelfStock + " " +
                                         order.product.stock.StoreStock).ToString();

                    FileStream fsProduct = new FileStream(@"Ürün.txt", FileMode.Open);
                    StreamWriter streamWriterProduct = new StreamWriter(fsProduct);

                    streamWriterProduct.Write(lineUpdateProduct);
                    streamWriterProduct.Flush();
                    streamWriterProduct.Close();
                    fsProduct.Close();
                }
            }
        }

        private void btnListSales_Click(object sender, EventArgs e)
        {
            //Satış.txt dosyasının içeriği richtextBox a yazdırılır.

            FileStream fsCustomer = new FileStream(@"Satış.txt", FileMode.Open);
            StreamReader streamReader = new StreamReader(fsCustomer);
            richTextBoxSales.Text = streamReader.ReadToEnd();
            streamReader.Close();
            fsCustomer.Close();
        }

        private void btnSalesClose_Click(object sender, EventArgs e)
        {
            Application.Exit();     //Uygulama kapatılır.
        }

        private void btnSalesHomePage_Click(object sender, EventArgs e)
        {
            Shope shope1 = new Shope();     //Shope sayfasına yönlendirilir.
            shope1.Show();
            this.Hide();
        }

        private void salesUpdate_Click(object sender, EventArgs e)
        {   
            //Satış.txt dosyasındaki satış kaydı ve ürün.txt dosyasındaki ürün stoğu güncellenir.

            OrderClass orderUpdate = new OrderClass();

            StreamReader streamReaderSales = new StreamReader(@"Satış.txt");

            string line, lineUpdateSales;
            int i = 0;

            List<string> lines = new List<string>();
            while ((line = streamReaderSales.ReadLine()) != null)
            {
                lines.Add(line);
            }
            streamReaderSales.Close();

            foreach (string lineList in lines)
            {
                string[] parts = lineList.Split(' ');

                order.OrderNum = int.Parse(parts[0]);
                if (order.OrderNum == int.Parse(txtUpSalesNum.Text))
                {

                    File.WriteAllLines(@"Satış.txt", File.ReadAllLines(@"Satış.txt").Where(s => !s.StartsWith(order.OrderNum + " ")));

                    order.OrderQuantity = int.Parse(txtNewPruductQuantity.Text);
                    order.customer.CustomerNumber = int.Parse(txtNewCusNum.Text);
                    order.customer.CustomerName = txtNewCusName.Text;
                    order.customer.CustomerSurname = txtNewCusSurname.Text;
                    order.product.ProductNumber = int.Parse(txtNewPruductNum.Text);
                    order.product.ProductName = txtNewPruductName.Text;
                    order.product.ProductType = txtNewPruductType.Text;
                    order.product.ProductPrice = int.Parse(txtNewPruductPrice.Text);
                    order.OrderPrice = order.OrderQuantity * order.product.ProductPrice;
                    FileStream fsSales = new FileStream(@"Satış.txt", FileMode.Append);
                    StreamWriter streamWriterSales = new StreamWriter(fsSales);
                    lineUpdateSales = (order.OrderNum + " " +
                           order.OrderQuantity + " " +
                           order.OrderPrice + " " +
                           order.customer.CustomerNumber + " " +
                           order.customer.CustomerName + " " +
                           order.customer.CustomerSurname + " " +
                           order.product.ProductNumber + " " +
                           order.product.ProductName + " " +
                           order.product.ProductType + " " +
                           order.product.ProductPrice).ToString();
                    streamWriterSales.Write(lineUpdateSales);
                    streamWriterSales.Flush();
                    streamWriterSales.Close();
                    fsSales.Close();
                    i++;
                }
            }
            if (i == 0)
            {
                MessageBox.Show("Güncellenecek Satış Kaydı Bulunamadı");
            }
        }

        private void addSales_Click(object sender, EventArgs e)
        {
            //Satış.txt dosyasına ve Müşteri.txt dosyasına yeni kayıt eklenir ve Ürün.txt dosyasındaki ürün miktarı değiştirilir.

            FileStream fsCustomer = new FileStream(@"Müşteri.txt", FileMode.Append);
            FileStream fsSales = new FileStream(@"Satış.txt", FileMode.Append);
            StreamWriter streamWriterSales = new StreamWriter(fsSales);
            StreamWriter streamWriterCustomer = new StreamWriter(fsCustomer);

            string lineCustomer;
            string lineSales;

            order.customer.CustomerNumber = int.Parse(txtCusNum.Text);
            order.customer.CustomerName = (txtCusName.Text).ToString();
            order.customer.CustomerSurname = (txtCusSurname.Text).ToString();

            order.product.ProductNumber = int.Parse(txtSalesProNum.Text);
            order.product.ProductName = txtSalesProName.Text;
            order.product.ProductType = txtSalesProType.Text;
            order.product.ProductPrice = int.Parse(txtSalesProPrice.Text);

            order.OrderNum = int.Parse(txtOrderNum.Text);
            order.OrderQuantity = int.Parse(txtOrderQuantity.Text);
            order.OrderPrice = order.OrderQuantity * order.product.ProductPrice;

            ProductClass product = new ProductClass();

            StreamReader streamReaderProduct = new StreamReader(@"Ürün.txt");

            string line, lineUpdateSalesProduct;
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
                product.ProductName = parts[1];
                product.ProductType = parts[2];
                product.ProductPrice = double.Parse(parts[3]);
                product.stock.ShelfStock = int.Parse(parts[4]);
                product.stock.StoreStock = int.Parse(parts[5]);

                if (product.ProductNumber == order.product.ProductNumber)
                {
                    if (product.stock.ShelfStock >= order.OrderQuantity)
                    {
                        File.WriteAllLines(@"Ürün.txt", File.ReadAllLines(@"Ürün.txt").Where(s => !s.StartsWith(order.product.ProductNumber + " ")));

                        FileStream fsProduct = new FileStream(@"Ürün.txt", FileMode.Append);
                        StreamWriter streamWriter = new StreamWriter(fsProduct);


                        product.stock.ShelfStock -= order.OrderQuantity;

                        lineUpdateSalesProduct = (product.ProductNumber + " " +
                                         product.ProductName + " " +
                                         product.ProductType + " " +
                                         product.ProductPrice + " " +
                                         product.stock.ShelfStock + " " +
                                         product.stock.StoreStock).ToString();


                        streamWriter.Write(lineUpdateSalesProduct);
                        streamWriter.Flush();
                        streamWriter.Close();

                        fsProduct.Close();
                        i++;
                    }
                    if (product.stock.ShelfStock + product.stock.StoreStock >= order.OrderQuantity)
                    {
                        product.stock.StoreStock = product.stock.ShelfStock + product.stock.StoreStock - order.OrderQuantity;
                        product.stock.ShelfStock = 0;

                        File.WriteAllLines(@"Ürün.txt", File.ReadAllLines(@"Ürün.txt").Where(s => !s.StartsWith(order.product.ProductNumber + " ")));

                        FileStream fsProduct = new FileStream(@"Ürün.txt", FileMode.Append);
                        StreamWriter streamWriter = new StreamWriter(fsProduct);


                        lineUpdateSalesProduct = (product.ProductNumber + " " +
                                         product.ProductName + " " +
                                         product.ProductType + " " +
                                         product.ProductPrice + " " +
                                         product.stock.ShelfStock + " " +
                                         product.stock.StoreStock).ToString();


                        streamWriter.Write(lineUpdateSalesProduct);
                        streamWriter.Flush();
                        streamWriter.Close();

                        i++;
                    }
                }
            }
            if (i == 0)
            {
                MessageBox.Show("Seçilen Üründen Yeterli Stok Bulunmadığı İçin Satılamaz");
            }
            if (i == 1)
            {
                lineSales = (order.OrderNum + " " +
               order.OrderQuantity + " " +
               order.OrderPrice + " " +
               order.customer.CustomerNumber + " " +
               order.customer.CustomerName + " " +
               order.customer.CustomerSurname + " " +
               order.product.ProductNumber + " " +
               order.product.ProductName + " " +
               order.product.ProductType + " " +
               order.product.ProductPrice).ToString();

                lineCustomer = (order.customer.CustomerNumber + " " +
                                order.customer.CustomerName + " " +
                                order.customer.CustomerSurname).ToString();

                streamWriterCustomer.WriteLine(lineCustomer);
                streamWriterSales.WriteLine(lineSales);
            }

            streamWriterCustomer.Flush();
            streamWriterSales.Flush();
            streamWriterCustomer.Close();
            streamWriterSales.Close();
            fsCustomer.Close();
            fsSales.Close();
        }
    }
}
