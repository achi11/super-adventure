using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static int sum(int number)
        {
            int s = 0;
            for (int i = number; i >0 ; i--)
            {
                s += number % 10;
                number /= 10;
            }
            return s;    
        }
        static void Main(string[] args)
        {
            Console.WriteLine(sum(347));
        }
    }
}
