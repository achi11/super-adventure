using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        static int Get(int number)
        {
            return number % 10;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(Get(234));

        }
    }
}
