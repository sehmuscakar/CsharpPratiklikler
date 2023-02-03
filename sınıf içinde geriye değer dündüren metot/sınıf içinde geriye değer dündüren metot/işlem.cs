using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sınıf_içinde_geriye_değer_dündüren_metot
{
    class işlem
    {
        public int topla(int s1,int s2)// buda geriye değer dündüren metot oluşumu işte 

        {
            int s3 = s1 + s2;
         //   return s3; bunu yazdırmanın altına yazmalısın ki okuma işlemi olsun yazdırsın sonra geriye değeri dündürsün 

            Console.Write("sonuç:"+s3);// büyle yaparsan yan yana yazar writline ile alt alta 
            return s3;// yani dündürme işlemi en son yapılır unutma 
        }
        public int kare (int deger)
        {

            int sonuc = deger * deger;
            Console.WriteLine("sonuc:" + sonuc);
            return sonuc;
        }
    }
}
