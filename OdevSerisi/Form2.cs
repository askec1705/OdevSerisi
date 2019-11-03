using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework;
using MetroFramework.Forms;

namespace OdevSerisi
{
    public partial class Form2 : MetroForm
    {
        int pilavFiyat = 5;
        int kebapFiyat = 10;
        public Form2()
        {
            InitializeComponent();
        }
        /*
         1) Form açıldığında ComboBox'lar içerisinde Kebap ve Pilav yemekleri eklenecek.
         2) Kullanıcı her bir CB farklı bir yemek seçecek, aynı yemek seçilemez. (1 ana yemek, 1 ara yemek) 
         3) Porsiyon bilgisi olarak, sadece sayısal değerler girilebilecek. sayı harici kullanıma kapatılacak.
         4) CB içerisinden seçilen yemeğe göre PB'larda o yemeğe ait resimler gösterilecek.
         5) Yemek ve Porsiyon bilgisi boş geçilemez, Kullanıcı bol geçerse,uyarı verdiriniz.
         6) Sipariş Iptal butonuna tıklanırsa, tüm alanlar temizlenip yeni bir sipariş için hazır hale getirilecek.
         7) Sipariş Özeti butonuna tıklanırsa, Kullanıcın seçtiği yemekler ve porsiyon bilgileri ekranda gösterilecek.
         8) Sipariş Al butonuna tıklanırsa, Kullanıcıya ödemisi gereken tutar ekranda yazdırılacak.
         9) Pilav birim fiyatı 5 TL, Kebap 10TL

         */
        private void btnSiparisAl_Click(object sender, EventArgs e)
        {
            try
            {
                double GelenDeger1 = double.Parse(textBox1.Text);
            }
            catch
            {
                MessageBox.Show("Lütfen sayısal olarak değer giriniz!");
            }

            try
            {
                double GelenDeger2 = double.Parse(textBox2.Text);
            }
            catch
            {
                MessageBox.Show("Lütfen sayısal olarak değer giriniz!");
            }
            


            if (cmbBirinciYemek.Text != cmbIkinciYemek.Text)
            {
                MetroMessageBox.Show(this, "Sipariş Alındı", "Sipariş Bildirimi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Lütfen 1 ana yemek 1 ara yemek seçiniz.");
            }
            
            

        }

        private void metroTile2_Click(object sender, EventArgs e)
        {
            cmbBirinciYemek.Items.Clear();
            cmbIkinciYemek.Items.Clear();
            textBox1.Text = "";
            textBox2.Text = "";
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            cmbBirinciYemek.Items.Add("Lütfen Yemek Seçiniz");
            cmbBirinciYemek.Items.Add("Kebap");
            cmbBirinciYemek.Items.Add("Pilav");

            cmbIkinciYemek.Items.Add("Lütfen Yemek Seçiniz");
            cmbIkinciYemek.Items.Add("Kebap");
            cmbIkinciYemek.Items.Add("Pilav");

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
             if (textBox1.Text == "Pilav")
            {
                
            }
        }

        private void metroTile3_Click(object sender, EventArgs e)
        {
            
        }

        private void metroLabel6_Click(object sender, EventArgs e)
        {
            int porsiyon1 = int.Parse(textBox1.Text);
            int porsiyon2 = int.Parse(textBox2.Text);
            int toplamtutar = (pilavFiyat + kebapFiyat) * (porsiyon1 + porsiyon2);
          
        }
    }
}
