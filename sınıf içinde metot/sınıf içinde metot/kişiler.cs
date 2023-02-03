using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sınıf_içinde_metot
{
    class kişiler
    {

        public void kişilistesi(string ad ) // bu bi metot geriye değer dündürmeyen metot 
        {
            for(int i = 0; i < 10; i++)
            {
                //   Console.WriteLine(i+ " .kişi"); paremetre almadan 
                Console.WriteLine(ad);
                // metot içinde bulunan değerler ya klavyeden girilir yada kod ile girilir 

            }
            
        }
    }
}
