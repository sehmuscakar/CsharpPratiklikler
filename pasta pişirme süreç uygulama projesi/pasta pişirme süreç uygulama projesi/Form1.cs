using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pasta_pişirme_süreç_uygulama_projesi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Value += 10;
            if (progressBar1.Value % 20 == 10)//cubuğun değeri 20 bülümünden kalan 10 ise label rengi red olur 
            {
                label1.BackColor = Color.Red;
            }
            if (progressBar1.Value % 20 == 0) // 20 ye bülümden kalan 0 ise white olur label rengi 
            {
                label1.BackColor = Color.White;
            }

            if (progressBar1.Value == 100)
            {
                MessageBox.Show("1 adım gerçekleşti");
                timer1.Stop();
                timer2.Start();
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            progressBar2.Value += 5;

            if (progressBar2.Value % 10 == 0) 
            {
                label2.BackColor = Color.White;
            }
            if (progressBar2.Value % 10 == 5) 
            {
                label2.BackColor = Color.Red;
            }

            if (progressBar2.Value == 100)
            {
                timer2.Stop();
            }
        }
    }
}
