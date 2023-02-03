using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace int_değişkenler
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /* int sayi;
             sayi = 24;
             label1.Text = sayi.ToString();// bu metod olduğu için parentez var , int ise yazdırmak için bazı araclarda 
            
            // stringe cevirmen lazım
         */
            /* int sayi1, sayi2, toplam;
             sayi1 = 5;
             sayi2 = 4;
             toplam = sayi1 + sayi2;
             label1.Text = toplam.ToString();// toplam int olduğu için yazması için string olması lazım 
            */

            int kenar, alan, cevre;
            kenar = 10;
            alan = kenar * kenar;
            cevre = kenar * 4;
            label1.Text = "Alan:" + alan + " çevre" + cevre;// eğer string bi ifade var ise cevirelecek olan aracta tostring yapmana gerek yok 
            // örnek alan string olduğu için alanda to dtring yapmana gerek yok en az bir tane büyle durum var ise de gecerli yani
            //------------------------------------

            
                }

        private void button2_Click(object sender, EventArgs e)
        {
            // kalvyeden veri girişi 
            /* int sayi;
             sayi = Convert.ToInt32(textBox1.Text);//textboxtan gelen degeri cevir ki sıkıntı olmasın cevirme büyle olur 
             label3.Text = sayi.ToString();// burda da label string olduğu için cevirdik 
            */
            int sayi, sonuc;
            sayi = Convert.ToInt32(textBox1.Text);
            sonuc = sayi * sayi * sayi;
            label3.Text = sonuc.ToString();
        }
    }
}
