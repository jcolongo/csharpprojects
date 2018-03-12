using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bozx
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int i=0; i < 100000000; i++)
            {
                Console.WriteLine("-----");
                Console.WriteLine("-   -");
                Console.WriteLine("-   -");
                Console.WriteLine("-----");
                System.Threading.Thread.Sleep(500);
                Console.Clear();
                Console.WriteLine("     ");
                Console.WriteLine("-----");
                Console.WriteLine("-   -");
                Console.WriteLine("-   -");
                Console.WriteLine("-----");
                System.Threading.Thread.Sleep(500);
                Console.Clear();
            }
        }
    }
}
