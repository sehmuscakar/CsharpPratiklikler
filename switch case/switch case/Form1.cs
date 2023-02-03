using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace switch_case
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
             // ay takvimi
            int ay = Convert.ToInt16(textBox1.Text);
            switch (ay)
            {
                case 1: label2.Text = "ocak"; break;//her vcase sonunda yani durum sonunda break yazılır yanı dgüden cık durumu kır 
                case 2: label2.Text = "şubat"; break;
                case 3: label2.Text = "mart"; break;
                case 4: label2.Text = "nisan"; break;
                case 5: label2.Text = "mayıs"; break;
                case 6: label2.Text = "haziran"; break;
                case 7: label2.Text = "temuz"; break;
                case 8: label2.Text = "ağustos"; break;
                case 9: label2.Text = "eylül"; break;
                case 10: label2.Text = "ekim"; break;
                case 11: label2.Text = "kasım"; break;
                case 12: label2.Text = "aralık"; break; // case yapısı buyle bide bunların dişinda nir değer girilirse oda default olarak yapıyoz
                                                        // eğer default tanımlamasan ve başka değer girer sen gene hatta vermez ama hiç bişey vermez yani

                default:label2.Text = "hattalı ay"; break;
            }
            */
            // string değeri ile de yapalım
            // mevsimler ile ilgili
            string mevsim = textBox1.Text;
            switch (mevsim)
            {
                case "yaz": label2.Text = "haziran temuz ağustos";// string olanlarda da büyle kulnılır switch case yapısı,büyük küçük harf duyarlılığı var unutma 
                    break;
                case "sonbahar": label2.Text = "eylül ekim kasım";
                    break;
                case "kış":
                    label2.Text = "aralık ocak şubat";
                    break;
                case "ilkbahar":
                    label2.Text = "mart nisan mayıs";
                    break;
                default: label2.Text = "hattalı mevsim";
                    break;

            }
        }
    }
}
