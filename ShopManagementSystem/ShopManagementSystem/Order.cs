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
    public partial class Order : Form
    {
        OrderClass order = new OrderClass();
        int lastOrderQuaintity = 0;

        public Order()
        {
            InitializeComponent();
        }

        private void addOrder_Click(object sender, EventArgs e)
        {
            //Sipariş.txt dosyasına sipariş eklenmesi ve ürün mikarının değiştirilmesi sağlanır.

            FileStream fsOrder = new FileStream(@"Sipariş.txt", FileMode.Append);
            StreamWriter streamWriter0 = new StreamWriter(fsOrder);
            string lineOrder;
            order.OrderNum = int.Parse(txtOrderNo.Text);
            order.OrderQuantity = int.Parse(txtOrderQuantity.Text);
            order.OrderPrice = double.Parse(txtOrderPrice.Text);
            order.product.ProductNumber = int.Parse(txtProNum.Text);
            order.product.ProductName = txtProName.Text;
            order.product.ProductType = txtProType.Text;
            order.product.ProductPrice = double.Parse(txtProPrice.Text);
            order.supplier.SupplierNumber = int.Parse(txtSupplierNum.Text);
            order.supplier.SupplierName = txtSupplierName.Text;

            lineOrder = (order.OrderNum + " " +
                         order.OrderQuantity + " " +
                         order.OrderPrice + " " +
                         order.product.ProductNumber + " " +
                         order.product.ProductName + " " +
                         order.product.ProductType + " " +
                         order.product.ProductPrice + " " +
                         order.supplier.SupplierNumber + " " +
                         order.supplier.SupplierName).ToString();

            streamWriter0.WriteLine(lineOrder);

            streamWriter0.Flush();
            streamWriter0.Close();
            fsOrder.Close();


            FileStream fsSupplier = new FileStream(@"Tedarikçi.txt", FileMode.Append);
            StreamWriter streamWriterSup = new StreamWriter(fsSupplier);
            string lineOrderSup;

            lineOrderSup = (order.supplier.SupplierNumber + " " +
                            order.supplier.SupplierName).ToString();

            streamWriterSup.WriteLine(lineOrderSup);
            streamWriterSup.Flush();
            streamWriterSup.Close();
            fsSupplier.Close();

            FileStream fsProduct00 = new FileStream(@"Ürün.txt", FileMode.Append);
            fsProduct00.Close();
            StreamReader streamReader0 = new StreamReader(@"Ürün.txt");

            ProductClass productUpdate = new ProductClass();

            string line, lineUpdateProduct;
            int i = 0;

            List<string> lines = new List<string>();

            while ((line = streamReader0.ReadLine()) != null)
            {
                lines.Add(line);
            }
            streamReader0.Close();

            if (lines.Count != 0)
            {
                foreach (string lineList in lines)
                {
                    string[] parts = lineList.Split(' ');

                    productUpdate.ProductNumber = int.Parse(parts[0]);
                    if (order.product.ProductNumber == productUpdate.ProductNumber)
                    {
                        File.WriteAllLines(@"Ürün.txt", File.ReadAllLines(@"Ürün.txt").Where(s => !s.StartsWith(productUpdate.ProductNumber + " ")));

                        productUpdate.ProductName = parts[1];
                        productUpdate.ProductType = parts[2];
                        productUpdate.ProductPrice = double.Parse(parts[3]);
                        productUpdate.stock.ShelfStock = int.Parse(parts[4]);
                        productUpdate.stock.StoreStock = int.Parse(parts[5]);

                        productUpdate.stock.StoreStock += order.OrderQuantity;

                        FileStream fsProduct0 = new FileStream(@"Ürün.txt", FileMode.Append);
                        StreamWriter streamWriterProduct = new StreamWriter(fsProduct0);

                        lineUpdateProduct = (productUpdate.ProductNumber + " " +
                                             productUpdate.ProductName + " " +
                                             productUpdate.ProductType + " " +
                                             productUpdate.ProductPrice + " " +
                                             productUpdate.stock.ShelfStock + " " +
                                             productUpdate.stock.StoreStock).ToString();

                        streamWriterProduct.WriteLine(lineUpdateProduct);

                        streamWriterProduct.Flush();
                        streamWriterProduct.Close();
                        fsProduct0.Close();

                        i++;
                    }
                }
                if (i == 0)
                {
                    order.product.ProductNumber = int.Parse(txtProNum.Text);
                    order.product.ProductName = txtProName.Text;
                    order.product.ProductType = txtProType.Text;
                    order.product.ProductPrice = double.Parse(txtProPrice.Text);
                    order.product.stock.ShelfStock = 0;
                    order.product.stock.StoreStock = order.OrderQuantity;

                    FileStream fsProduct1 = new FileStream(@"Ürün.txt", FileMode.Append);
                    StreamWriter streamWriterProduct = new StreamWriter(fsProduct1);

                    lineUpdateProduct = (order.product.ProductNumber + " " +
                                        order.product.ProductName + " " +
                                        order.product.ProductType + " " +
                                        order.product.ProductPrice + " " +
                                        order.product.stock.ShelfStock + " " +
                                        order.product.stock.StoreStock).ToString();

                    streamWriterProduct.WriteLine(lineUpdateProduct);

                    streamWriterProduct.Flush();
                    streamWriterProduct.Close();
                    fsProduct1.Close();
                }
            }
            else
            {
                FileStream fsProduct2 = new FileStream(@"Ürün.txt", FileMode.Append);
                StreamWriter streamWriterProduct = new StreamWriter(fsProduct2);
                string lineAddProduct;

                order.product.stock.StoreStock += order.OrderQuantity;

                lineAddProduct = (order.product.ProductNumber + " " +
                                  order.product.ProductName + " " +
                                  order.product.ProductType + " " +
                                  order.product.ProductPrice + " " +
                                  order.product.stock.ShelfStock + " " +
                                  order.product.stock.StoreStock).ToString();

                streamWriterProduct.WriteLine(lineAddProduct);
                streamWriterProduct.Flush();
                streamWriterProduct.Close();
                fsProduct2.Close();
            }
        }
        private void deleteOrder_Click(object sender, EventArgs e)
        {
            //Verilen siparişin silinmesi ve sipariş önceki ürün miktarına dönülmesi işlemnleri yapılır.

            OrderClass orderDelete = new OrderClass();
            orderDelete.OrderNum = int.Parse(txtDelOrderNo.Text);

            StreamReader srOrder = new StreamReader(@"Sipariş.txt");

            List<string> orderLines = new List<string>();
            string lineOrder;

            while ((lineOrder = srOrder.ReadLine()) != null)
            {
                orderLines.Add(lineOrder);
            }
            srOrder.Close();
            foreach (string linesOrder in orderLines)
            {
                string[] partsOrder = linesOrder.Split(' ');
                if (int.Parse(partsOrder[0]) == int.Parse(txtDelOrderNo.Text))
                {
                    lastOrderQuaintity = int.Parse(partsOrder[1]);
                }
            }

            File.WriteAllLines(@"Sipariş.txt", File.ReadAllLines(@"Sipariş.txt").Where(s => !s.StartsWith(orderDelete.OrderNum + " ")));

            orderDelete.supplier.SupplierNumber = int.Parse(txtDelSuppNum.Text);
            File.WriteAllLines(@"Tedarikçi.txt", File.ReadAllLines(@"Tedarikçi.txt").Where(s => !s.StartsWith(orderDelete.supplier.SupplierNumber + " ")));


            orderDelete.product.ProductNumber = int.Parse(txtDelProductNum.Text);
            StreamReader srProduct = new StreamReader(@"Ürün.txt");

            string line, lineUpdateProduct;
            int i = 0;

            List<string> lines = new List<string>();

            while ((line = srProduct.ReadLine()) != null)
            {
                lines.Add(line);
            }
            srProduct.Close();

            foreach (string lineListProduct in lines)
            {
                string[] partsProduct = lineListProduct.Split(' ');

                order.product.ProductNumber = int.Parse(partsProduct[0]);
                if (orderDelete.product.ProductNumber == order.product.ProductNumber)
                {
                    File.WriteAllLines(@"Ürün.txt", File.ReadAllLines(@"Ürün.txt").Where(s => !s.StartsWith(orderDelete.product.ProductNumber + " ")));


                    orderDelete.product.ProductName = partsProduct[1];
                    orderDelete.product.ProductType = partsProduct[2];
                    orderDelete.product.ProductPrice = double.Parse(partsProduct[3]);
                    orderDelete.product.stock.ShelfStock = int.Parse(partsProduct[4]);
                    orderDelete.product.stock.StoreStock = int.Parse(partsProduct[5]) - lastOrderQuaintity;

                    lineUpdateProduct = (order.product.ProductNumber + " " +
                                         orderDelete.product.ProductName + " " +
                                         orderDelete.product.ProductType + " " +
                                         orderDelete.product.ProductPrice + " " +
                                         orderDelete.product.stock.ShelfStock + " " +
                                         orderDelete.product.stock.StoreStock).ToString();


                    FileStream fsUpdateProduct = new FileStream(@"Ürün.txt", FileMode.Append);
                    StreamWriter streamWriterProduct = new StreamWriter(fsUpdateProduct);

                    streamWriterProduct.WriteLine(lineUpdateProduct);
                    streamWriterProduct.Flush();
                    streamWriterProduct.Close();
                    fsUpdateProduct.Close();
                    i++;

                }
            }
            if (i == 0)
            {
                File.WriteAllLines(@"Ürün.txt", File.ReadAllLines(@"Ürün.txt").Where(s => !s.StartsWith(orderDelete.product.ProductNumber + " ")));
            }
        }
        private void listOrder_Click(object sender, EventArgs e)
        {
            //Sipariş.txt dosyası richTextBox a yazdırılır.

            FileStream fsOrder = new FileStream(@"Sipariş.txt", FileMode.Open);
            StreamReader streamReader = new StreamReader(fsOrder);
            richTextBoxOrder.Text = streamReader.ReadToEnd();
            streamReader.Close();
            fsOrder.Close();
        }

        private void orderUpdate_Click(object sender, EventArgs e)
        {
            //Verilen siparişin güncellenmesi ve ürün miktarının güncellenmesi sağlanır.

            OrderClass orderUpdate = new OrderClass();

            StreamReader streamReaderOrder = new StreamReader(@"Sipariş.txt");

            string line, lineUpdateOrder, lastOrderQuaintity;
            int i = 0;

            List<string> lines = new List<string>();

            while ((line = streamReaderOrder.ReadLine()) != null)
            {
                lines.Add(line);
            }
            streamReaderOrder.Close();

            foreach (string lineList in lines)
            {
                string[] parts = lineList.Split(' ');

                order.OrderNum = int.Parse(parts[0]);

                if (order.OrderNum == int.Parse(txtUpOrderNum.Text))
                {
                    lastOrderQuaintity = parts[1];
                    File.WriteAllLines(@"Sipariş.txt", File.ReadAllLines(@"Sipariş.txt").Where(s => !s.StartsWith(order.OrderNum + " ")));

                    order.OrderQuantity = int.Parse(txtNewOrderQuantity.Text);
                    order.OrderPrice = double.Parse(txtNewOrderPrice.Text);
                    order.product.ProductNumber = int.Parse(txtNewProductNum.Text);
                    order.product.ProductName = txtNewProName.Text;
                    order.product.ProductType = txtNewProType.Text;
                    order.product.ProductPrice = double.Parse(txtNewProPrice.Text);
                    order.supplier.SupplierNumber = int.Parse(txtNewSupplierNum.Text);
                    order.supplier.SupplierName = txtNewSupplierName.Text;


                    FileStream fsUpdateOrder = new FileStream(@"Sipariş.txt", FileMode.Append);
                    StreamWriter streamWriterOrder = new StreamWriter(fsUpdateOrder);

                    lineUpdateOrder = (order.OrderNum + " " +
                                       order.OrderQuantity + " " +
                                       order.OrderPrice + " " +
                                       order.product.ProductNumber + " " +
                                       order.product.ProductName + " " +
                                       order.product.ProductType + " " +
                                       order.product.ProductPrice + " " +
                                       order.supplier.SupplierNumber + " " +
                                       order.supplier.SupplierName).ToString();

                    streamWriterOrder.WriteLine(lineUpdateOrder);
                    streamWriterOrder.Flush();
                    streamWriterOrder.Close();
                    fsUpdateOrder.Close();
                    i++;

                    StreamReader streamReader0 = new StreamReader(@"Ürün.txt");

                    ProductClass productUpdate = new ProductClass();

                    string lineProduct, lineUpdateProduct;
                    int j = 0, lastStoreStock;

                    List<string> linesProduct = new List<string>();

                    while ((lineProduct = streamReader0.ReadLine()) != null)
                    {
                        linesProduct.Add(lineProduct);
                    }
                    streamReader0.Close();

                    if (lines.Count != 0)
                    {
                        foreach (string lineListProduct in linesProduct)
                        {
                            string[] partsProduct = lineListProduct.Split(' ');

                            productUpdate.ProductNumber = int.Parse(partsProduct[0]);
                            if (int.Parse(txtNewProductNum.Text) == productUpdate.ProductNumber)
                            {
                                File.WriteAllLines(@"Ürün.txt", File.ReadAllLines(@"Ürün.txt").Where(s => !s.StartsWith(productUpdate.ProductNumber + " ")));



                                productUpdate.ProductName = partsProduct[1];
                                productUpdate.ProductType = partsProduct[2];
                                productUpdate.ProductPrice = double.Parse(partsProduct[3]);
                                productUpdate.stock.ShelfStock = int.Parse(partsProduct[4]);
                                lastStoreStock = int.Parse(partsProduct[5]) - int.Parse(lastOrderQuaintity);
                                productUpdate.stock.StoreStock = lastStoreStock;

                                productUpdate.stock.StoreStock += order.OrderQuantity;

                                FileStream fsProduct0 = new FileStream(@"Ürün.txt", FileMode.Append);
                                StreamWriter streamWriterProduct = new StreamWriter(fsProduct0);

                                lineUpdateProduct = (productUpdate.ProductNumber + " " +
                                                     productUpdate.ProductName + " " +
                                                     productUpdate.ProductType + " " +
                                                     productUpdate.ProductPrice + " " +
                                                     productUpdate.stock.ShelfStock + " " +
                                                     productUpdate.stock.StoreStock).ToString();

                                streamWriterProduct.WriteLine(lineUpdateProduct);

                                streamWriterProduct.Flush();
                                streamWriterProduct.Close();
                                fsProduct0.Close();

                                j++;
                            }
                        }
                        if (j == 0)
                        {
                            order.product.ProductNumber = int.Parse(txtNewProductNum.Text);
                            order.product.ProductName = txtNewProName.Text;
                            order.product.ProductType = txtNewProType.Text;
                            order.product.ProductPrice = double.Parse(txtNewProPrice.Text);
                            order.product.stock.ShelfStock = 0;
                            order.product.stock.StoreStock = int.Parse(txtNewOrderQuantity.Text);

                            FileStream fsProduct1 = new FileStream(@"Ürün.txt", FileMode.Append);
                            StreamWriter streamWriterProduct = new StreamWriter(fsProduct1);

                            lineUpdateProduct = (order.product.ProductNumber + " " +
                                                order.product.ProductName + " " +
                                                order.product.ProductType + " " +
                                                order.product.ProductPrice + " " +
                                                order.product.stock.ShelfStock + " " +
                                                order.product.stock.StoreStock).ToString();

                            streamWriterProduct.WriteLine(lineUpdateProduct);

                            streamWriterProduct.Flush();
                            streamWriterProduct.Close();
                            fsProduct1.Close();
                        }
                    }
                    else
                    {
                        FileStream fsProduct2 = new FileStream(@"Ürün.txt", FileMode.Append);
                        StreamWriter streamWriterProduct = new StreamWriter(fsProduct2);
                        string lineAddProduct;

                        order.product.ProductNumber = int.Parse(txtNewProductNum.Text);
                        order.product.ProductName = txtNewProName.Text;
                        order.product.ProductType = txtNewProType.Text;
                        order.product.ProductPrice = double.Parse(txtNewProPrice.Text);
                        order.product.stock.ShelfStock = 0;
                        order.product.stock.StoreStock = int.Parse(txtNewOrderQuantity.Text);

                        order.product.stock.StoreStock += order.OrderQuantity;

                        lineAddProduct = (order.product.ProductNumber + " " +
                                          order.product.ProductName + " " +
                                          order.product.ProductType + " " +
                                          order.product.ProductPrice + " " +
                                          order.product.stock.ShelfStock + " " +
                                          order.product.stock.StoreStock).ToString();

                        streamWriterProduct.WriteLine(lineAddProduct);
                        streamWriterProduct.Flush();
                        streamWriterProduct.Close();
                        fsProduct2.Close();
                    }
                }
            }
            if (i == 0)
            {
                MessageBox.Show("Güncellenecek Sipariş Kaydı Bulunamadı");
            }
        }

        private void btnOrderHomePage_Click(object sender, EventArgs e)
        {
            Shope shope1 = new Shope();     //Shope sayfasına yönlendirilir.
            shope1.Show();
            this.Hide();    
        }

        private void btnOrderClose_Click(object sender, EventArgs e)
        {
            Application.Exit();     //Uygulama kapatılır.
        }
    }
}
