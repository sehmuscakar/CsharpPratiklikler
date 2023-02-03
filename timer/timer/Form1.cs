using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace timer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }
        int sayac = 0;// ama global olarak tanımlarsan yanı scop dışına o zamn olur 
        private void timer1_Tick(object sender, EventArgs e)
        {
          //  int sayac = 0; bunu buraya yazarsan sonsuz bir düngünün içine girer 
            sayac++;
            label1.Text = sayac.ToString();
            // not eğer sayacı durdurmasan int aralığına kadar devam eder 
            if (sayac == 20)
            {
              //  timer1.Stop();// 50 ye ulaştığında duracak 
                this.BackColor = Color.PeachPuff;// this bu anlamında yani üzerinde calışılan 

            }
            if (sayac == 40)
            {
               
                this.BackColor = Color.LightCyan;// this bu anlamında yani üzerinde calışılan 

            }


            if (sayac == 45)
            {
                this.BackColor = Color.Green;
                sayac = 0;

            }
        }
    }
}
