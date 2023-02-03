using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sınıf_içinde_geriye_değer_dündüren_metot
{
    class Program
    {
        static void Main(string[] args)
        {
            işlem isl = new işlem();
            isl.topla(7, 6);// parentez içindeki paremetreler
            Console.WriteLine("\n\n");
            isl.kare(5);
            Console.Read();


        }
    }
}
