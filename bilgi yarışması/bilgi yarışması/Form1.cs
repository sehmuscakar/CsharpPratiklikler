using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bilgi_yarışması
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int soruno = 0, dogru = 0, yanlış = 0;// buda artırma ile ilgili yani her bastığında

        private void BTNB_Click(object sender, EventArgs e)
        {
            BTNA.Enabled = false;
            BTNB.Enabled = false;
            BTNC.Enabled = false;
            BTND.Enabled = false;
            BTNSONRAKİ.Enabled = true;
            label5.Text = BTNB.Text;
            if (label4.Text == label5.Text)
            {
                dogru++;
                LBLDOĞRU.Text = dogru.ToString();
            }
            else
            {
                yanlış++;
                LBLYANLIŞ.Text = yanlış.ToString();
            }
        }

        private void BTNC_Click(object sender, EventArgs e)
        {
            BTNA.Enabled = false;
            BTNB.Enabled = false;
            BTNC.Enabled = false;
            BTND.Enabled = false;
            BTNSONRAKİ.Enabled = true;
            label5.Text = BTNC.Text;
            if (label4.Text == label5.Text)
            {
                dogru++;
                LBLDOĞRU.Text = dogru.ToString();
            }
            else
            {
                yanlış++;
                LBLYANLIŞ.Text = yanlış.ToString();
            }
        }

        private void BTND_Click(object sender, EventArgs e)
        {
            BTNA.Enabled = false;
            BTNB.Enabled = false;
            BTNC.Enabled = false;
            BTND.Enabled = false;
            BTNSONRAKİ.Enabled = true;
            label5.Text = BTND.Text;
            if (label4.Text == label5.Text)
            {
                dogru++;
                LBLDOĞRU.Text = dogru.ToString();
            }
            else
            {
                yanlış++;
                LBLYANLIŞ.Text = yanlış.ToString();
            }
        }

        private void BTNA_Click(object sender, EventArgs e)
        {

            BTNA.Enabled = false;
            BTNB.Enabled = false;
            BTNC.Enabled = false;
            BTND.Enabled = false;
            BTNSONRAKİ.Enabled = true;

            label5.Text = BTNA.Text;
            if (label4.Text == label5.Text)
            {
                dogru++;
                LBLDOĞRU.Text = dogru.ToString();
            }
            else
            {
                yanlış++;
                LBLYANLIŞ.Text = yanlış.ToString();
            }
        }

        private void BTNSONRAKİ_Click(object sender, EventArgs e)
        {
            BTNA.Enabled = true;
            BTNB.Enabled = true;
            BTNC.Enabled = true;
            BTND.Enabled = true;
            BTNSONRAKİ.Enabled = false;

            soruno++;
            //  soruno = soruno + 1; bu kulanım yukardaki tanımladığın global olan ile aynı farkı yok artırma ilgili
            LBLSORUNO.Text = soruno.ToString();
            if (soruno == 1)
            {
                richTextBox1.Text = " cumhuriyet kaç yılında ilan edilmiştir";
                BTNA.Text = "1920";
                BTNB.Text = "1921";
                BTNC.Text = "1922";
                BTND.Text = "1923";
                label4.Text = "1923";
            }
            if (soruno == 2)
            {
                richTextBox1.Text = " hangi il ege bülgesinde bulunmaz";
                BTNA.Text = "izmir";
                BTNB.Text = "balıkesir";
                BTNC.Text = "aydın";
                BTND.Text = "manisa";
                label4.Text = "balıkesir";
            }
            if (soruno == 3)
            {
                richTextBox1.Text = " son kuşlar hangi yazarımıza aitir";
                BTNA.Text = "sait faik";
                BTNB.Text = "cemal süreya";
                BTNC.Text = "atila ilhan";
                BTND.Text = "reşat nuri";
                label4.Text = "sait faik";
            }
            if (soruno == 3)
            {
                BTNA.Enabled = false;
                BTNB.Enabled = false;
                BTNC.Enabled = false;
                BTND.Enabled = false;
                BTNSONRAKİ.Enabled = false;
                MessageBox.Show("doğru:" + dogru + " \n" + "yanlış" + yanlış);
            }
        }
    }
}
