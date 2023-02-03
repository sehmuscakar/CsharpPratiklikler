using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace formlar_arası_veri_taşıma
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2();
            frm.mesaj = textBox1.Text;// dğer formda mesağ değişkeni oluşturduk ama global olarak oluşturduk ki buraya da gelebilsinn
            frm.Show(); // frm nesnesini güster 
            this.Hide(); // form1 i gizle 
        }
    }
}
