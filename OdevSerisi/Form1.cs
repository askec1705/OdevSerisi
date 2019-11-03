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
    public partial class Form1 : MetroForm
    { 
        /*
         1) Kullanıcı çekiliş yap butonuna tıkladığında sol baştan başlayarak, 1 ile 49 arasında(49 dahil ) sayı üretecek.
         2) her bi kutuda toplamda 10 adet sayı gösterildikten sonra, 10. üretilen sayı ekrana sabitlecek ve dizi içerisinde tutulacak.
         3) 2. kutudan itibaren 10. sırada gelen sayı daha önce üretildiyse, yeni bir sayı üretilecek ve benzersiz olana kadar bu işlem devam edecek.
         4) 6 kutuda benzersiz sayı üretildikten sonra küçükten büyüğe doğru sıralama yapılacak ve ekrana yazdırılacak.
         5) kullanıcı çekiliş yap dediğinde ekran eski haline gelip tekrar çekiliş yapabilecek ( kullanıcı işlem devam ederkende yeniden başlatabilir.)
             */
        public Form1()
        {
            InitializeComponent();
        }
        Random rnd = new Random();
        int rastgele;
        int[] sayilar = new int[6];//yeni dizi oluşturduk.
        private void metroTile1_Click(object sender, EventArgs e)
        {
            Array.Clear(sayilar,0,sayilar.Length);
            int sayac = 0;
            while (sayac < 6)
            {
                rastgele = rnd.Next(1, 50); //1 ile 49 arasında rastgele sayı üretiliyor

                if (Array.IndexOf(sayilar, rastgele) == -1)  //dizinin içinde aynı sayı yoksa
                {
                    sayilar[sayac] = rastgele;  //üretilen rastgele sayiyi dizinin sayac kaç ise o elemanına ata
                    sayac++; //sayacı bir artır
                }

            }

            Array.Sort(sayilar);//diziyi küçükten büyüğe sıralar
            textBox1.Text = sayilar[0].ToString(); //textBox1'e sayilar dizisinin 1.elemanını yaz
            textBox2.Text = sayilar[1].ToString(); //textBox2'ye sayilar dizisinin 2.elemanını yaz
            textBox3.Text = sayilar[2].ToString(); //textBox3'e sayilar dizisinin 3.elemanını yaz
            textBox4.Text = sayilar[3].ToString(); //textBox4'e sayilar dizisinin 4.elemanını yaz
            textBox5.Text = sayilar[4].ToString(); //textBox5'e sayilar dizisinin 5.elemanını yaz
            textBox6.Text = sayilar[5].ToString(); //textBox6'ya sayilar dizisinin 6.elemanını yaz
        }
    }
}
