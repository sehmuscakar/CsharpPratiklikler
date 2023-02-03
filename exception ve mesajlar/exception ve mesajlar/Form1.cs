using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exception_ve_mesajlar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // eğer hatta yoksa bu blok tek calışır ama eğer bi hatta var ise catch blogu calışır 
                int s1, s2, sonuc;
                s1 = Convert.ToInt32(textBox1.Text);
                s2 = Convert.ToInt32(textBox2.Text);
                sonuc = s1 * s2;
                label1.Text = sonuc.ToString();
            }
            catch (Exception hata )// burda hata adında bir hata türetim 
            {

                MessageBox.Show(hata.ToString());// burada ise bu hata yı msj olarak bize geri dündür tostringe cevir ve dündür 
                // programı patlatma ;hatta almayı önlemek için 

                //not:finally bloğu kulanlırsa hata ister olsun ister olmasın kod clışır ama 
                //eğer hatta yok ise try ile fnaly calışır 
                //eğer hatta var  ise catch ile fianly blokları birlikte calışır 
                
            }
            finally
            {
                MessageBox.Show("finally kodu çalıştı");
            }
        }
    }
}
