using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace enum_yapısı
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        enum sehirler { x,adana,adıyaman,afyon,ağrı,amasya,ankara,antalya,artvin,aydın}// enum buyle oluşturulur,0 inci index ten başlar 
        private void button1_Click(object sender, EventArgs e)
        {
            // enum yapısı:karar yapılarının cok olduğu verilerin büyle ardışık olduğu yerlerde kulanılır 
            // enum :sıralama anlamında zaten,sıralı liste 
            int plaka = Convert.ToInt32(textBox1.Text);
            sehirler s;// enumun sehirler dizinden s değeri türetik 
            s = (sehirler)plaka;// bu da sehirlerin plaka değerini güsteririr yani 2 girdiğinde adıyaman gelir 
            //dizi tanımlarken nasıl i kulnaımı ile vardı bu da benzer  mesela sınıf dizinde [i] bu kulnaım ineexi getirir örek verityim 
            // sınıf[i] bu ise sınıf dizisinde index değerlerini getirir üyle düşün enum yapısınıda sadece küşeli parentez değil normal parentez 
            label1.Text = s.ToString();// burda da işte s değerini türetmiştik bu değeri diziye benzer bi şekilde 
            // eşitledik ve bu değeri label e yazdırdık, (sehirler)plaka  bu anlam sehirler dizisinde plaka= index  gibi düşün o index değerini getir anlamında 
            //(sehirler)plaka  enumun plaka ıncı değeri yani 
        }
    }
}
