using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex10
{
    class Program
    {
        static int Majority(int[] arr)
        {
            Array.Sort(arr);
            int counter = 1;
            int max = 0;
            int maxvalue = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == arr[i + 1])
                {
                    counter++;
                }
                else
                {
                    if (counter > max)
                    {
                        max = counter;
                        maxvalue = arr[i];                        
                    }
                    counter = 1;
                }

            }
            return maxvalue;
        }
        static void Main(string[] args)
        {

        }
    }
}
