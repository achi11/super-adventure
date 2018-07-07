using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex8
{
    class Program
    {
        static void  Remove(int[] wholeArr, int[] arrayOfRemoving)
        {
            for (int i = 0; i < arrayOfRemoving.Length; i++)
            {
                for (int j = 0; j < wholeArr.Length; j++)
                {
                    if (wholeArr[j] == arrayOfRemoving[i])
                    {
                        wholeArr[j] = Remove();
                    }
                }
            }
        }
        static void Main(string[] args)
        {

        }
    }
}
