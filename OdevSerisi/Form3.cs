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
    public partial class Form3 : MetroForm
    {
        public Form3()
        {
            InitializeComponent();
        }

        /*
        Kullanıcı Serial butonuna tıkladığında, numericupdown'lardan girilen değerlere göre serial oluşturulacak.
        her biri için değerler, arkatarafta oluşturulan guid'lerden üretilerek ilgili textbox'lara yazdırılacak.
        Örnek hane sayısı 2, karakter sayısı 5 seçilirse,
        Sayısal  : 23512-56723
        Metinsel : ESTHW-DLWOPC
        Serial   : 3ER4Z-F45R1
             
             
        */
        private void Form3_Load(object sender, EventArgs e)
        {
            btnSerial.Text = Guid.NewGuid().ToString();
        }
    }
}
