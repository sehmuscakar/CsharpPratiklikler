using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Try_catch_bloğu_kulanımı
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //try catch :bu kod hattanın ününe gecilsin diye yani kod patlamasın gibisinen 
            try
            {
                // buraya normal yazdığın kodu girersin yani httalı ise de 
                int sayi1 = Convert.ToInt16(textBox1.Text);
                int sayi2 = Convert.ToInt16(textBox2.Text);
                int toplam = sayi1 + sayi2;
                MessageBox.Show(toplam.ToString());

            }
            catch(Exception)
            {
                // buraya da hatta olan kısmı hatta olarak geri dündürmesin uyarı olarak geri dündürsün 
                MessageBox.Show("lütfen değerlerinizi kontrol ediniz");

            }
        }
    }
}
