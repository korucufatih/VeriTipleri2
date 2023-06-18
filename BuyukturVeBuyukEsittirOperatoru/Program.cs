using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuyukturVeBuyukEsittirOperatoru
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int yas = 17;
            int yas2 = 18;
            int yas3 = 16;
            int yas4 = 16;
            bool KontrolEt2 = yas3 >= yas4;
            bool KontrolEt = yas2 > yas;
            Console.WriteLine(KontrolEt2);
            Console.WriteLine(KontrolEt);
            Console.ReadLine();

        }
    }
}
