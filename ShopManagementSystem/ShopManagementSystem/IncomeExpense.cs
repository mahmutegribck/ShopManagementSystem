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
    public partial class IncomeExpense : Form
    {
        public IncomeExpense()
        {
            InitializeComponent();
        }

        private void btnAddExpense_Click(object sender, EventArgs e)
        {
            //Giderler.txt dosyası oluşturulur veya açılır ve textboxlardan alınan veriler dosyaya yazılır.

            FileStream fileStream = new FileStream(@"Giderler.txt", FileMode.Append);
            StreamWriter streamWriter = new StreamWriter(fileStream);

            string expensesLine;

            IncomeExpenseClass expenses = new IncomeExpenseClass();

            expenses.ExpenseElectricity = double.Parse(txtElectricity.Text);
            expenses.ExpenseFood = double.Parse(txtFood.Text);
            expenses.ExpenseStaff = double.Parse(txtStaff.Text);
            expenses.ExpenseHeating = double.Parse(txtHeating.Text);

            expensesLine = (expenses.ExpenseElectricity + " " +
                           expenses.ExpenseFood + " " +
                           expenses.ExpenseStaff + " " +
                           expenses.ExpenseHeating).ToString();

            streamWriter.WriteLine(expensesLine);
            streamWriter.Flush();
            streamWriter.Close();
            fileStream.Close();
        }

        private void btnListExpense_Click(object sender, EventArgs e)
        {
            //Giderler.txt dosyası richTextBox a yazdırılır.

            FileStream fsExpense = new FileStream(@"Giderler.txt", FileMode.Open);
            StreamReader streamReader = new StreamReader(fsExpense);
            richTextBoxExpense.Text = streamReader.ReadToEnd();
            streamReader.Close();
            fsExpense.Close();
        }

        private void btnListIncome_Click(object sender, EventArgs e)
        {
            //Satış.txt dosyası richTextBox a yazdırılır.

            FileStream fsIncome = new FileStream(@"Satış.txt", FileMode.Open);
            StreamReader streamReader = new StreamReader(fsIncome);
            richTextBoxIncome.Text = streamReader.ReadToEnd();
            streamReader.Close();
            fsIncome.Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit(); //Uygulama kapatılır.
        }

        private void btnHomePage_Click(object sender, EventArgs e)
        {
            Shope shope1 = new Shope();     //Shope formuna dönülür.
            shope1.Show();
            this.Hide();
        }
    }
}
