using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace for_döngüsü
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
            
            // 10 defa merahaba yazdırır 
            int i;
            for (i = 1; i <= 10; i++)
            {
                listBox1.Items.Add(i+"merhaba batman");// 10 defa bizi yazdırmak zorunda klmadan yaparız böyle
                // i yi kulanım sebebi sıra numarasını index yani görmek 
            }
            */
            // 1 den 10 kadar yazdırma 

            for(int i = 0; i < 100; i++)
            {
                listBox1.Items.Add(i);
            }
        }
    }
}
