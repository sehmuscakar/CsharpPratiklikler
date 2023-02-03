using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace captcha_oluşturma
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
       // Random modelini int olanlar için rahat kulanabilriz ama string ve semboler için captcha oluşturma yapmak lazım 
       // bu da dizi oluştururarak yapılır 
        private void button1_Click(object sender, EventArgs e)
        {
            string[] sembol1 = { "a", "b", "c", "d", "f", "g" };
            string[] sembol2 = { "+", "-", "*", "/", "#" };
            Random r = new Random();
            int s1, s2, s3;
            s1 = r.Next(0, sembol1.Length);// sembol1 dizisinin uzunluğunua kadar 
            s2 = r.Next(0, sembol2.Length);
            s3 = r.Next(0, 10);
            // label1.Text = s1.ToString();//büyle olursa dizinn index numarasını yazdırır 
            label1.Text = sembol1[s1].ToString() + sembol2[s2].ToString() + s3.ToString();
        }
    }
    }
}
