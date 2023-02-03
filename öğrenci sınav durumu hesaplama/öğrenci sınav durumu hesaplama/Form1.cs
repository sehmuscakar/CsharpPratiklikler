using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace öğrenci_sınav_durumu_hesaplama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double s1, s2, proje, ort; // hepsini double yap ki bülümde bi sıkıntı olmasın 
            string durum;
            s1 = Convert.ToDouble(textBox1.Text);
            s2 = Convert.ToDouble(textBox2.Text);
            proje = Convert.ToDouble(textBox3.Text);

            ort = (s1 + s2 + proje) / 3;
            if(ort>=50)
            {
                durum = "gecti";
            }
           else
            {
                durum = "kaldi";
            }
            textBox4.Text = ort.ToString("0.00") + " / " + durum;
        }
    }
}
