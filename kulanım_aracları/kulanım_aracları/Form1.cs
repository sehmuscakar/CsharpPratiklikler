using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kulanım_aracları
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("MERHABA DÜNYA");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label2.Text = "BARAN";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label6.Text = "EMEL";
            label7.Text = "öztürk";
            label8.Text = "öğretmen";

        }

        private void button4_Click(object sender, EventArgs e)
        {
            //textBox1.Text = "yazılım mühendisliği";
            //nereye yazdıracaksan orası sol ,nereden veya ne yazdıracaksanız oda sağ tarafta
            label9.Text = textBox1.Text;
        }
    }
}
