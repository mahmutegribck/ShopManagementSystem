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
    public class IncomeExpenseClass
    {
        private double expenseElectricity;
        private double expenseStaff;
        private double expenseFood;             //Gelir-gider değerlerini tutacak değişkenler tanımlandı.
        private double expenseHeating;
        private double income;
        private double expenseOrder;

        public double ExpenseElectricity { get => expenseElectricity; set => expenseElectricity = value; }
        public double ExpenseStaff { get => expenseStaff; set => expenseStaff = value; }
        public double ExpenseFood { get => expenseFood; set => expenseFood = value; }
        public double ExpenseHeating { get => expenseHeating; set => expenseHeating = value; }
        public double Income { get => income; set => income = value; }
        public double ExpenseOrder { get => expenseOrder; set => expenseOrder = value; }
    }
}
