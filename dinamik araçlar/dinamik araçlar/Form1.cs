using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dinamik_araçlar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        // racları bide kodlar ile oluşturalım
        private void button1_Click(object sender, EventArgs e)
        {
            Button btn = new Button();// button sınıfından nesne türetik 
            Point btnkonum = new Point(20, 10);// burda x=20,y=10 , burda point sınıfından yararlandık 
            btn.Location = btnkonum;//burda btn nesnesinin yerini ayarladık 
            btn.Name = "Button1";
            btn.Text = "Tıkla";
            btn.BackColor = Color.Green;
            btn.Height = 50;//yükseklik
            btn.Width = 75;//genişlik
           this.Controls.Add(btn);// bu formun konroleri içerisinde ekle ,yani bu button1 içerisinde 
            // btn nesnesinin özeliklerini de kontolunu sağla anlamında aktifleştir yani tanımlanan özelikleeri 
            // bunu yapmasan olmaz 

            Label lbl = new Label();
            Point lblkonum = new Point(250, 30);
            lbl.Location = lblkonum;// bu lblkonum eşitledik ya burda point sınıfında lblkonum tanımlanıyor yani o yüzdeb 
            lbl.Name = "Label1";
            lbl.Text = "Merhaba";
            lbl.BackColor = Color.Yellow;
            this.Controls.Add(lbl);
            lbl.AutoSize = true; // otomatik boyutlandırma 

            // birden fazla textbox oluşturalım , bi arac birden fazla oluşturulursa
            // 5 tane txtbox oluşturacaz 
            for (int i = 1; i <= 5; i++)
            {
                // burda ki düngü de olan şeyleri iyi anla 
                TextBox txt = new TextBox();
                Point txtkonum = new Point(350,i*30);
                txt.Location = txtkonum;
                txt.Name = "Textbox" + i;
                txt.Text = i.ToString();// burda i yi düünüştürmemiz lazım 
                this.Controls.Add(txt);



            }
        }
    }
}
