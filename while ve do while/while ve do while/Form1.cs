using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace while_ve_do_while
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
            int i = 1;
            while (i <= 10)
            {
                listBox1.Items.Add("Batman");//10 defa batman
                listBox2.Items.Add(i);// i değerlerini yazacak
                i++; // artırma işlemi 

            }

            int j = 1;
            int toplam = 0;
            while (j <= 5)
            {
                toplam = toplam + j;
                j++;
            }
            MessageBox.Show(toplam.ToString());
            */
        }
            
        private void button2_Click(object sender, EventArgs e)
        {
            // burda normal olmaması lazım ama bir kere oluyor 
            int i = 12;
            do
            {
                listBox3.Items.Add("merhaba batman");
                i++;
            }
            while (i <= 10);// burda normalde ; kulnımlmaz ama bu istisna döngülerde 
        }
    }
}
