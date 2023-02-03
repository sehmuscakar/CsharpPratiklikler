using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace metotlar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void temizle() // bu geriye değer düdürmeyen bir metot örnehi ,private yi yazmasaydık ta otomatık üyle algılayacaktı 
// void geriye değer kulanılmadığında kulanlır 
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox1.Focus();

        }

        void renklendir()
        {
            textBox1.BackColor = Color.Gray;
            textBox2.BackColor = Color.Black;
            textBox3.BackColor = Color.Blue;
            textBox4.BackColor = Color.Gray;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            temizle();// geri renkte küp rengi metot anlamında ve altında anahtar olması private anlamında 

        }

        private void button2_Click(object sender, EventArgs e)
        {
            renklendir();
        }
        int toplam(int s1,int s2)// bunlar paremetre dir unutma 
        {
            int s3 = s1 + s2;
            return s3;// gerye s3 dündürülür 
        }
        private void button3_Click(object sender, EventArgs e)
        {
            label1.Text = toplam(4, 6).ToString();// 4,6 değerini verdik metodu stringe cevirdik
            label2.Text = toplam(2, 3).ToString();
            label3.Text = toplam(4, 8).ToString();
        }

        // not: eğer yanlışlıkla bir şeye forma,butona vs onu consolda sildiğinizde 
        // geriye değer dündüren return
        // void:boş gecersiz geriye değer dündürmeyen anlamında 
        // return ise geriye değer dündüren anlamında veri türü burda belirlenir
        // metodlar oluşturulurken global olarak oluşturulur 

    }
}
