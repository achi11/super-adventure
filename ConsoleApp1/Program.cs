using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
       static int pow(int x ,int y)
        {
            for (int i = 0; i < y; i++)
            {
                x *= 10;
            }
            return x/10;
        }
        static double Get(int number, int n)
        {

            int k = pow(10, number.ToString().Length-n);
           
            return ((number/k)%10);
        }
        static void Main(string[] args)
        {
            Console.WriteLine(Get(12124,2));
         
        }
    }
}
