using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace combobox_ve_listbox_kulanımaracları
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            comboBox1.Items.Add("ANTALYA");// BURDA ADD METODU İLE EKLEDİK BUTONA NE KADAR BASARSAN ANTALYA EKLER
            // AMA DİREK COMBOBOX UN STRİNG EDİT COLESCTİONS BÜLÜMDEN EKLERSEN DAHA KOLAY 

        }

        private void button2_Click(object sender, EventArgs e)
        {
            comboBox1.Items.Add(textBox1.Text);//bu textboxtaki klavyeden girilen değeri combobaxa ta güzükmesinisağlar

        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("kasiyer");//burda da kod ile ekliyoruz 
            listBox1.Items.Add("futbolcu");
            listBox1.Items.Add("muhasebeci");
            listBox1.Items.Add("antrenör");// eğer cok olursa listbox ta kaydırma cubugu gelir

        }

        private void button4_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(textBox2.Text);//burda textbox larda text yazmayı unutma ,textbox2 deki girdiğin verileri
                                              //listbox1 de gözükecek
            //listBox1.Items.Add(textBox2.Text + " " + textBox1.Text);//textbox2 deki ve sonra textbox1 deki değeri yazdırır



        }
    }
}
