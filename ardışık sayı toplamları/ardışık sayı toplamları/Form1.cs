using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ardışık_sayı_toplamları
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
            //ardışık sayıların toplamı 10 kadar 
            int toplam =0;
            for(int i = 1; i <= 10; i++)
            {
                toplam = toplam + i;
            }
            label1.Text = toplam.ToString();
            */
            // ift sayıları yazdıran 10 kadar
            /*
            int toplam = 0;
            for (int i = 2; i <= 10; i+=2)
            {
                toplam = toplam + i;
            }
            label1.Text = toplam.ToString();
            */
        }

        private void button2_Click(object sender, EventArgs e)
        {
            /*
            for (int i = 1; i <= 100; i++)
            {

                if(i%5==0 && i % 7 == 0)// 5 ile 7 ye tam bülünenler
                {
                    listBox1.Items.Add(i);
                }
            }
            */
            // sayi inin i ye tam bülümleri mesela

            int sayi = Convert.ToInt32(textBox1.Text);
            for(int i = 1; i <= sayi; i++)
            {
                if (sayi % i == 0)
                {
                    listBox1.Items.Add(i);// mesala sayi 100 ise 100 tam bülümleri verecek
                }

            }
            
        }
    }
}
