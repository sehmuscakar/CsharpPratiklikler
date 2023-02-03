using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace alışveriş_indirim_tutar_hesaplam
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int kitapadet;
            double toplam;
            kitapadet = Convert.ToInt16(textBox1.Text);
            if(kitapadet>=0 && kitapadet <= 20)
            {
                toplam = (kitapadet * 8) - (kitapadet * 8 * 0.20);// burda toplamın yüzde 20 sini cıkarıyoruz indirim 
                label3.Text = toplam + " TL";// BURDA sen tl yi string olarak yazdığın için toplam da otomatik olarak string olur cevirmene gerek yok 
                // yoksa olmaz cevirmen lazım
            }

            if(kitapadet >=21 && kitapadet <= 40)
            {
                toplam = (kitapadet * 8) - (kitapadet * 8 * 0.40);
                label3.Text = toplam + " TL";
            }
            if (kitapadet >= 41 )
            {
                toplam = (kitapadet * 8) - (kitapadet * 8 * 0.50);
                label3.Text = toplam + " TL";
            }
        }
    }
}
