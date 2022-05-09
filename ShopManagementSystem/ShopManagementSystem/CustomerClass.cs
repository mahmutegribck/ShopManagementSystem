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
    public class CustomerClass
    {
        private int customerNumber;         //Müşteri bilgilerini tutacak değişkenler tanımlandı
        private string customerName;    
        private string customerSurname;

        public int CustomerNumber { get => customerNumber; set => customerNumber = value; }
        public string CustomerName { get => customerName; set => customerName = value; }
        public string CustomerSurname { get => customerSurname; set => customerSurname = value; }

    }
}
