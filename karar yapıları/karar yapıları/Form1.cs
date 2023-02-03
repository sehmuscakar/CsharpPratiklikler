using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace karar_yapıları
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
            if (textBox1.Text == "ali")
            {
                label1.Text = "doğru";
            }
            else
            {
                label1.Text = "yanlış";
            }
            */
            //------------------------
            /*
            int sayi = Convert.ToInt32(textBox1.Text);
            if (sayi == 5)
            {
                label1.Text = "doğru";

            }
            else
            {
                label1.Text = "yanlış";
            }
            */
            //---------------------
            /*
            int sayi = Convert.ToInt32(textBox1.Text);
            if (sayi % 2 == 0)
            {

                label1.Text = "cift";

            }
            else
            {
                label1.Text = "tek";

            }
            */

            /*   int sayi = Convert.ToInt32(textBox1.Text);
               if(sayi%2==0 && sayi>=10)// ve oprertorü
                   {
                   label1.Text = "sayi 10 dan buyuk ve cift ";
               }
               else// else de parentez yok direk kod bloku 
               {
                   label1.Text = "10 dan büyük değil ya da cift değil ";
               }
            */

            int sayi = Convert.ToInt32(textBox1.Text);
            if (sayi % 2 == 0 || sayi >= 10)// veya oprertorü
            {
                label1.Text = "sayi 10 dan buyuk ve cift ";
            }
            else// else de parentez yok direk kod bloku 
            {
                label1.Text = "10 dan büyük değil ya da cift değil ";
            }

        }
    }
}
