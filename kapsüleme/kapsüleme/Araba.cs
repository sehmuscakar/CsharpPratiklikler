using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kapsüleme
{
    class Araba
    {
        public string renk;
        public int hiz;
        public double motor;
        public char durum;
        public int fiyat;
        private int yil;
        private string marka;

        // kapsüleme 

        public int YIL // ilk ünce yil için yapalım 
        {
            get { return yil; }// bana geriye değer dündür anlamında bu get bloku ,Bir özelliğin değeri okunmak istenildiğinde o özelliğe ait GET metodu çalışır.
            set { yil = Math.Abs(value); } // buda ayarla anlamında abs de mutlak değer ile ilgili,ayarla anlamında işte örnek mutlak ı bişekilde gelmesini istedik 
        }

        public string MARKASI// büyle olan bişey başka bi ismle yeniden yapıyormuşuz gibi anla 
        {
            get { return marka; }// yani bu klanım büyle unutma
            set { marka = value.ToUpper(); } // MESELA burda da hepsini büyük harf yaptık 
            // value değer anlamında yani neyese o andaki değer marka ,yil gibi eşitleme işlemi yapıyorsun üyle işte 

        }
    }
}
