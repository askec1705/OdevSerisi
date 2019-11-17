using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;

namespace OdevSerisi
{
    public partial class lblGmailComTr : MetroForm
    {
        /*
         Kullanıcı TextBox' a tek veya birden fazla mail adresi girebilir 
         Örnek info@hotmail.com  veya info@bilgeadam.com;info@gmail.com

        Girilen mailler arkatarafta bir dizi içerisinde tutulacak
        Kullanıcı Ayrıştır butonuna tıklarsa, dizi içerisinde yer alan mailler ilgili listbox'lara eklenecek ve mail sayıları ilgili label'lara yazdırılacak.

        formata uymayan mailler ise, çöp kutusuna eklenecek.
         */
        public lblGmailComTr()
        {
            InitializeComponent();
        }
        string[] mailAdresler = new string[0];
        int sayi1 = 0;
        int sayi2 = 0;
        int sayi3 = 0;
        int sayi4 = 0;
        int sayi5 = 0;
        int sayi6 = 0;
        private void metroButton1_Click(object sender, EventArgs e)
        {
            Array.Resize(ref mailAdresler, mailAdresler.Length + 1);
            mailAdresler[mailAdresler.Length - 1] = mtxtGirisAlani.Text;
            mailAdresler = mtxtGirisAlani.Text.Split(';');
            mtxtGirisAlani.Clear();
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < mailAdresler.Length; i++)
            {
                if (mailAdresler[i].EndsWith("hotmail.com"))
                {
                    lstHotmailCom.Items.Add($"{mailAdresler[mailAdresler.Length - 1]} - {mailAdresler.Length - 1}");
                    lblHotmailCom.Text = sayi1.ToString();
                    sayi1++;
                }
                else if (mailAdresler[i].EndsWith("hotmail.com.tr"))
                {
                    lstHotmailComTr.Items.Add($"{mailAdresler[mailAdresler.Length - 1]} - {mailAdresler.Length - 1}");
                    lblHotmailComTr.Text = sayi2.ToString();
                    sayi2++;
                }
                else if (mailAdresler[i].EndsWith("hotmail.net"))
                {
                    lstHotmailNet.Items.Add($"{mailAdresler[mailAdresler.Length - 1]} - {mailAdresler.Length - 1}");
                    lblHotmailNet.Text = sayi3.ToString();
                    sayi3++;
                }
                else if (mailAdresler[i].EndsWith("gmail.com"))
                {
                    lstHotmailComTr.Items.Add($"{mailAdresler[mailAdresler.Length - 1]} - {mailAdresler.Length - 1}");
                    lblGmailCom.Text = sayi4.ToString();
                    sayi4++;
                }
                else if (mailAdresler[i].EndsWith("gmail.com.tr"))
                {
                    lstHotmailComTr.Items.Add($"{mailAdresler[mailAdresler.Length - 1]} - {mailAdresler.Length - 1}");
                    metroLabel18.Text = sayi5.ToString();
                    sayi5++;
                }
                else if (mailAdresler[i].EndsWith("gmail.net"))
                {
                    lstHotmailComTr.Items.Add($"{mailAdresler[mailAdresler.Length - 1]} - {mailAdresler.Length - 1}");
                    lblGmailNet.Text = sayi6.ToString();
                    sayi6++;
                }
                else
                {
                    lstCopKutusu.Items.Add($"{mailAdresler[mailAdresler.Length - 1]} - {mailAdresler.Length - 1}");
                }
                i++;
                if (i == mailAdresler.Length)
                {
                    MessageBox.Show("Bütün Elemanları Ayrıştırdınız.");
                }
            }
        }
    }
}
