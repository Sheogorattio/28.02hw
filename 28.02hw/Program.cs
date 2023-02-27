using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _28._02hw
{
    internal class Program
    {
        static void Swap<T>(ref T a, ref T b)
        {
            (a, b) = (b, a);
        }
        static void Main(string[] args)
        {
            int a = 10;
            int b = 40;
            Console.WriteLine("var a:{0}\nvar b{1}", a, b);
            Swap(ref a, ref b);
            Console.WriteLine("var a:{0}\nvar b{1}",a,b);
            Console.ReadKey();
        }
    }
}
