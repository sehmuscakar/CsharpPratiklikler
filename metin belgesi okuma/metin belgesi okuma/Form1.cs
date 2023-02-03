using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;// sistem kütüphanesi dosya işlemleri için gerekli 
namespace metin_belgesi_okuma
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(openFileDialog1.ShowDialog()==DialogResult.OK)// bu şu anlamında open file dialog açıldığında ben tamam bastığımda devreye girisn if yapısı bu anlamda 
            {
                StreamReader sr = new StreamReader(openFileDialog1.FileName);// open file dialog ta seçilen dosya adı anlamında paremetre adı okunacak değer yani  
                string satir = sr.ReadLine();// bu da satır oku anlamında ; her bir satırı sürekli okuyacak 
                while (satir != null)// burda satir null olmadığı sürece anlamında 
                {
                    listBox1.Items.Add(satir);
                    satir = sr.ReadLine();// yukardaki readline başlatıyor buda devam etiriyor 
                }
            }
        }
    }
}
