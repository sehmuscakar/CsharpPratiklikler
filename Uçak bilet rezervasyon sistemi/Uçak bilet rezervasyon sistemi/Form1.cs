using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Uçak_bilet_rezervasyon_sistemi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("Rota:" + comboBox1.Text + " " + comboBox2.Text+"Tarih:"+dateTimePicker1.Text+"saat: "+maskedTextBox1.Text+" yolcu bilgileri--AD:"+textBox1.Text+"TC:"+maskedTextBox2.Text+"Telefon:"+maskedTextBox3);
            //yukarda listboxa yazdırma işlemleri yaptık tam bak mantığını anla 
            MessageBox.Show("Yolcu kaydı yapıldı");// burdada kayıt olurken msj gelecek 



        }
    }
}
