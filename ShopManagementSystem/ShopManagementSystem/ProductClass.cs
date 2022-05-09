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
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopManagementSystem
{
    public class ProductClass
    {
        private int productNumber;
        private string productName;         //Ürün bilgilerini tutacak değikenler tanimlandı.
        private string productType;
        private double productPrice;

        public StockClass stock = new StockClass();     //Ürün stoklarının tutulacağı değikenlerin kullanımlası için stok nesnesi oluşturuldu.
        public int ProductNumber { get => productNumber; set => productNumber = value; }
        public string ProductName { get => productName; set => productName = value; }
        public string ProductType { get => productType; set => productType = value; }
        public double ProductPrice { get => productPrice; set => productPrice = value; }
    }
}
