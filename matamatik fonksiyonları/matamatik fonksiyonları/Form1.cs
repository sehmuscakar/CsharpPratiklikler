using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace matamatik_fonksiyonları
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        /*
         * Abs =mutlak
         * ceil= üste yuvarlama
         * floor=alta yuvarla
         * pow=üs alma
         * sqrt=kare kök
         */
        private void button1_Click(object sender, EventArgs e)
        {
            double sayi = Convert.ToDouble(textBox1.Text);// text box a double değeri gir anlamında yani 
                                                          // label2.Text = Math.Abs(sayi).ToString(); // burda da o değeri güster 
                                                          //  label2.Text = Math.Ceiling(sayi).ToString();
                                                          //  label2.Text = Math.Floor(sayi).ToString();
                                                          //label2.Text = Math.Pow(sayi,3).ToString();// sol alt sağ ise üst olur 
            label2.Text = Math.Sqrt(sayi).ToString();
        }

        
    }
}
