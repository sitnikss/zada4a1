using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    class Program
    {
        static void Main(string[] args)
        {
            int t = Convert.ToInt32(Console.ReadLine());
            int s = Convert.ToInt32(Console.ReadLine());
            double sk;
            t = t * 60;
            s = s * 1000;
            sk = s / t;
            Console.WriteLine(sk);
            Console.ReadKey();
        }
    }
}
