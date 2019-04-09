using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting
{
    class RelativeSorting
    {
        public static void fnRelativeSorting(int[] arr1, int[] arr2)
        {
            int max = arr1.Max();
            int[] temp = new int[max + 1];

            for (int i = 0; i < arr1.Length; i++)
            {
                temp[arr1[i]]++;
            }

            for (int i = 0; i < arr2.Length; i++)
            {
                while (temp[arr2[i]] != 0)
                {
                    Console.Write(arr2[i] + " ");
                    temp[arr2[i]]--;
                }
            }

            for (int i = 0; i < temp.Length; i++)
            {
                while (temp[i] != 0)
                {
                    Console.Write(i + " ");
                    temp[i]--;
                }
            }

            Console.WriteLine();
        }
    }
}
