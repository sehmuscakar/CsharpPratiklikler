using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace constructor_yapıcı__metot
{
    class ögrenci
    {
       public ögrenci()
        {
          
            Console.WriteLine("ad:baran");
            Console.WriteLine("soyad:yücedağ");
            Console.WriteLine("meslek:öğretmen");
       
            }
    
    public ögrenci(string bilgi)
        {
            Console.WriteLine(bilgi);
        }
    }
}
