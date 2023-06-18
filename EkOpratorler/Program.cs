using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EkOpratorler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 5;
           // a = a + 1;
            a += 1;
           // a = a - 2;
            a -= 2;
            //a = a * 3;
            a *= 3;
            //a = a / 4;
            a /= 4;
            Console.WriteLine("a'nın değeri:"+a);
            Console.ReadLine();
        }
    }
}
