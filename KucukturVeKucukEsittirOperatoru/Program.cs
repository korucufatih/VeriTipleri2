using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KucukturVeKucukEsittirOperatoru
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sayi1 = 39;
            int sayi2 = 19;
            bool KontrolEt = sayi1 < sayi2;
            bool KontrolEt2 = sayi2 <= sayi1;
            Console.WriteLine(KontrolEt);
            Console.WriteLine(KontrolEt2);
            Console.ReadLine();
        }
    }
}
