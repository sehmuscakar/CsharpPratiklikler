using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace menüstrip_kulanımı
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void maviToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.CadetBlue;//this bu anlamında // üztünde calıştığın seyin arka plan rengi değiştir
        }

        private void griToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Gray;
        }

        private void turuncuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Orange;
        }

        private void hakkımızdaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("bu peoje murat yücedağ tarafındanyapıldı", "bilgi");// bu aracında paremetreleri var bak bi ara istersen belki 
        }

        private void cıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();//uygulamadın çik 
        }

        private void madMacksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.youtube.com/watch?v=6xVREEH66iw");//buraya yünlendirecehin adresini yazacan tırnak içine 
            label1.Text = "mad max değil kemal sunal";
        }
    }
}
