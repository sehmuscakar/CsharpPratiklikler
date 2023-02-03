using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sinema_büfe_satış_uygulaması
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int kasatutar = 0;// bu global olarak tanımladın yani bu bi kere 0 olacak aşahıda döngüye girdiği zaman hep aratacak yada azalacak 
        private void button1_Click(object sender, EventArgs e)
        {
            int misir, bilet, su, cay,toplam;
            misir = Convert.ToInt16(txtmısır.Text);
            bilet = Convert.ToInt16(txtbilet.Text);
            su = Convert.ToInt16(txtsu.Text);
            cay = Convert.ToInt16(txtcay.Text);
            toplam = misir * 4 + cay * 2 + su * 1 + bilet * 8;
            lbltoplam.Text = toplam.ToString()+" TL";

            kasatutar = kasatutar + toplam;
            lblkasa.Text = kasatutar.ToString()+" TL";// BUTTONU her defa bastığında bir döngü olarak düşün 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtbilet.Text = "";
            txtcay.Text = "";
            txtmısır.Text = "";
            txtsu.Text = "";
            txtmısır.Focus();// burda bu butona basıldığında txtbox lar temizlenir ve bu metodla 
            // imlec txtmısır a gider yani istediğin yere günderebilirsin 
        }
    }
}
