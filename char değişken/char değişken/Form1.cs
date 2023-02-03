using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace char_değişken
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
            //char da tek karekter kaplar ,string ten farklı tek tırnak ile yazılır 
            char takim;
            takim = 'G';// bellekte bir karekterlik yer kaplar 
            label1.Text = takim.ToString();// burda da stringe cevirmen lazım
            */
            // null değerler string te calışır ama char da calışmaz 
            char ders;
            ders = Convert.ToChar(textBox1.Text);//textbıx taki değeri tochar ile cevirdik ve ders değişkenine atik 
            label1.Text = ders.ToString();
        }
    }
}
