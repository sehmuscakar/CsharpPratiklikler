using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;//bu kütüphane dosya işlemlerinde kulanılır herhalde 
namespace metin_belgesi_oluşturma
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string dosyaadi, dosyayolu;
        StreamWriter sw;//stream akış writer yazıcı yani akış yazıcısı anlamında kulanılır ;dosyaya yazı yazmada kulanılıyor 
     // sw: bu kavram nesne yada dosyanın oluşması için gerkli 
        private void button2_Click(object sender, EventArgs e)
        {
            dosyaadi = textBox2.Text;// burda da dosyaadı belirtilir 

            sw = File.CreateText(dosyayolu + "\\" + dosyaadi + "txt");//burda ise dosya oluştur anlamında 
            // dosya yolu iki slaş bir tane olmaz sonra dosyaadi belirtlir sonra txt uzantısı eklenir bu kosdun sıralamsını öğren 
        }

        // dosya indiğinde baştan sona o stream oluyor,orda yazma işlemi ise de writer oluyor 
        private void button1_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)//DialogResult.OK şu kavram tamam basılırsa eğer anlamında sonuçlar tamm anlamında gibi düşün 
            {
                dosyayolu = folderBrowserDialog1.SelectedPath.ToString();// burdaki anlam ise klasör yolunu seç ve tostinge cevir dosyayolu değişkene at 
                textBox1.Text = dosyayolu;
            }

        }
    }
}
