using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex6
{
    class Program
    {
        static double GeneratRandom(int x,int y)
        {
            Random rnd = new Random();
            return rnd.Next(x, y);
        }
        static void Main(string[] args)
        {
            Console.WriteLine(GeneratRandom(3,5));
        }
    }
}
