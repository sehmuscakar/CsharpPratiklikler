using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace diziler_arrey_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*
            string[] kisiler = {"ali","ahmet","mehet","aslı","ayse","hakan","demet"};
            label1.Text = kisiler[4];// string olduğu için dünüştürme ye gerek yok 4 indextekini yazdırır
            */
            int[] sayilar = { 4, 7, 5, 6, 9, 8, 2, 3 };
            label1.Text = sayilar[5].ToString();// int olduğu için dünüştürme yapmamız lazım 


        }

        private void button2_Click(object sender, EventArgs e)
        {
            //string[] sehirler = { "ankara", "eskisehir", "antalya", "bursa", "balıkesir" };
            //for(int i = 0; i < sehirler.Length; i++)
            //{
            //    listBox1.Items.Add(sehirler[i]);// kulanım böyle// yani sehirler dizisinin idexlerinin değerlerini
            //
            //
            //}

            int[] sayilar = { 4, 2, 3, 1, 5, 6, 7, 9 };
            for(int i = 0; i < sayilar.Length; i++)// buda listler diziyi
            {
                if (sayilar[i] % 2 == 0)// cift sayılar 
                {
                    listBox1.Items.Add(sayilar[i]);// bu kulanıma dikkat et

                }

            }
        }
    }
}
