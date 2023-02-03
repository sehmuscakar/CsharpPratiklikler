using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace formlar_arası_geciş
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // form kısımları da aslında sınıf tır 
            Form2 fr = new Form2();
            fr.Show();// burda fr nesnesini güster yani form2 ye gütür anlamında 
            this.Hide();// buyle yaparsanda 1,ci formu gizler 
        }
    }
}
