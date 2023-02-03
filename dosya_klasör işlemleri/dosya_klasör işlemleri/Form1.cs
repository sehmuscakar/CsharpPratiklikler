using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dosya_klasör_işlemleri
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();// burda dialog pencersini göster anlamda örnek form penceresi ,masaöstü tiklandığında acılan pencere 
            //yani gürünen pencere dialog penceresidir 

        }

        private void button2_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();// buda open gibi ek olarak kayıt türü de burda acılır örnek işte filtreleme yapmak için gibisinden 

        }

        private void button3_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.ShowDialog();// buda direk klasörleri açar,klasör tarayıcı diyaloğu 
        }
        // bu üçü de formun arka olanında çalışır 
    }
}
