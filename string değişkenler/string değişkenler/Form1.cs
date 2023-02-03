using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace string_değişkenler
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*   string metin;//metin adlı string değişken adında oluşturduk,yeşil cizgi uyarıdır ,kırmızı hatta
               metin = "merhaba bugun 18 aralık 2021 çarşamba";
               label1.Text = metin;
            */
            /* string adsoyad, meslek;
             adsoyad = "eylül yücedağ";
             meslek = "öğretmen";
             label1.Text = adsoyad;
             label2.Text = meslek;
            */
            string sehir;
            sehir = textBox1.Text;// burda sen textbox a sehir girceksin 
            label3.Text = sehir;//buttona bastığında da burda gözükecek
        }
    }
}
