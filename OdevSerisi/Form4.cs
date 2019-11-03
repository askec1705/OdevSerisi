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
    }
}
