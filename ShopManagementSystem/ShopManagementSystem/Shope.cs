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
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShopManagementSystem
{
    public partial class Shope : Form
    {
        public Shope()
        {
            InitializeComponent();
        }

        private void btnStock_Click(object sender, EventArgs e)
        {
            Stock stock1 = new Stock();     //Stok işlemleri sayfasına yönlendirilir.
            stock1.Show();
            this.Hide();
        }

        private void btnSales_Click(object sender, EventArgs e)
        {
            Sales sales1 = new Sales();     //Satış işlemleri sayfasına yönlendirilir.
            sales1.Show();
            this.Hide();
        }

        private void btnIncomeExpense_Click(object sender, EventArgs e)
        {
            IncomeExpense incomeExpense1 = new IncomeExpense();         //Gelir-Gider işlemleri sayfasına yönlendirilir.
            incomeExpense1.Show();
            this.Hide();
        }

        private void btnProduct_Click(object sender, EventArgs e)
        {
            Product product1 = new Product();       //Ürün işlemleri sayfasına yönlendirilir.
            product1.Show();
            this.Hide();
        }

        private void btnCloseApp_Click(object sender, EventArgs e)
        {
            Application.Exit();     //Uygulama kapatılır.
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            Order order1 = new Order();     //Sipariş işlemleri sayfasına yönlendirilir.
            order1.Show();
            this.Hide();
        }
    }
}
