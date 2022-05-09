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
    public class OrderClass
    {
        private int orderNum;               //Sipariş bilgilerini tutacak değişkenler tanımlandı.
        private double orderPrice;
        private int orderQuantity;

        public ProductClass product = new ProductClass();   //Sipariş edilen ürünün bilgilerini tutması için ürün nesnesi oluşturuldu.
        public CustomerClass customer = new CustomerClass(); //Siparişi veren müşterinin bilgilerini tutacak müşteri nesnesi oluşturuldu.
        public SupplierClass supplier = new SupplierClass();  //Sipariş edilen ürününü tedarikçi bilgilerini tutacak tedarikçi nesnesi oluşturuldu.
        public int OrderNum { get => orderNum; set => orderNum = value; }
        public double OrderPrice { get => orderPrice; set => orderPrice = value; }
        public int OrderQuantity { get => orderQuantity; set => orderQuantity = value; }
    }
}
