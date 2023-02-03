using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sınıf_içinde_metot
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
              mesaj msj = new mesaj();
              msj.metin();// burda bu metot içinde ne varsa glir 
              Console.Read();
            */
            kişiler ks = new kişiler();
            //   ks.kişilistesi("şehmus");// bunu kod kısmından yazdık 

            string ads;
            Console.Write("isim girin");
            ads = Console.ReadLine();//klavyeden değer girmek için 
            ks.kişilistesi(ads);
            Console.Read();
        }
    }
}
