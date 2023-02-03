using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace forech_düngüsü
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
            string[] kisiler = { "ali", "ahmet", "mehmet", "mesut", "pınar", "berna" };
            foreach(string k in kisiler)// burda kisiler dizisi k ya atandı gibisinde daha kolay büyle
            {
                listBox1.Items.Add(k);
            }
            */
            int toplam=0;
            int[] sinavlar = { 70, 65, 85, 100, 90 };
            foreach(int x in sinavlar)
            {
                listBox1.Items.Add(x);
                toplam += x;//toplam =toplam+x; ile aynı 
            }
            label1.Text = toplam.ToString();
            // length 1 den başlar index 0 dan 
            int ortalama = toplam / sinavlar.Length;
            label2.Text = ortalama.ToString();
            
        }
    }
}
