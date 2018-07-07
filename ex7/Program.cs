using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex7
{
    class Program
    {
        static int FindMinIndex(int[] arr)
        {
            int min = arr[0];
            int minindex = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < min)
                {
                    min = arr[i];
                    minindex = i;
                }
            }
            return minindex;
        }
        static int[] RemoveAt(int[] arr, int index)
        {
            if (index < 0 || index >= arr.Length)
                return arr;
            var newarr = new int[arr.Length - 1];
            int j = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (i != index)
                {
                    newarr[j] = arr[i];
                    j++;
                }
            }
            return newarr;
        }
        static int[] Sort(int[] arr)
        {
            var sortarr = new int[arr.Length];
            for (int i = 0; i < arr.Length; i++)
            {
                sortarr[i] = arr[FindMinIndex(arr)];
                RemoveAt(arr, FindMinIndex(arr));
            }
            return sortarr;
        }
        static void Main(string[] args)
        {
            var a = new int[5] { 1, 2, 3, 5, 1 };
          var b= Sort(a);
            for (int i = 0; i < a.Length; i++)
            {
                Console.WriteLine(b[i]);
            }
        }
    }
}
