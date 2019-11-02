using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello_world
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hi!");
            int a, b;
            Console.WriteLine("\tEnter num 1: \n");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\tEnter num 2: \n");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\tResult: {0}", a+b);
            Console.ReadLine();
        }
    }
}
