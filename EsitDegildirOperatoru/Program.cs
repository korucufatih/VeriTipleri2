using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsitDegildirOperatoru
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string huy = "cimri";
            string isim = "fatih";
            bool kisilik = ( isim != huy) == true;
            bool KontrolEt2 = kisilik;
            int sayi1 = 3;
            int sayi2 = 4;
            bool KontrolEt = sayi1 != sayi2;
            Console.WriteLine(KontrolEt2);
            Console.ReadLine();
        }
    }
}
