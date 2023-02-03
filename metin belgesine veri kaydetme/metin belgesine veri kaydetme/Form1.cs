using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace metin_belgesine_veri_kaydetme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();
            saveFileDialog1.Filter = "metin dosyaları|*.txt";// slaşın sol tarafı filtreleme adı gibi sağ kısım ise uzantısı gibi 
            saveFileDialog1.Title = "metin belgeseli kayıt";// bu ise sol taraftaki başlik gibi düşün 
            saveFileDialog1.ShowDialog();// burda ise dialoku göster 
            StreamWriter sw = new StreamWriter(saveFileDialog1.FileName);// burda hangi dosyayı yazdıracak onu file name ile belirtiyoruz 
            sw.WriteLine(richTextBox1.Text);
            sw.Close();
            MessageBox.Show("kayıt oluşturuldu");
            // bu kod satırlarının sırası öneli özelikle filter önce yaz kodunu i filtereleme gelsin 
        }
    }
}
