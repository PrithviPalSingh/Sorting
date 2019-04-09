using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting
{
    class BinaryArraySorting
    {
        public static void fnBinaryArraySorting1(int[] arr)
        {
            int[] auxArr = new int[arr.Length];
            //fnBASInner(arr, auxArr, 0, arr.Length - 1);
            Merge(arr, auxArr, 0, arr.Length - 1, (arr.Length - 1) / 2);
            Console.WriteLine(string.Join(" ", arr));
        }

        private static void fnBASInner(int[] arr, int[] auxArr, int start, int end)
        {
            if (start >= end)
                return;

            int mid = start + (end - start) / 2;
            fnBASInner(arr, auxArr, start, mid);
            fnBASInner(arr, auxArr, mid + 1, end);
            Merge(arr, auxArr, start, end, mid);
        }

        private static void Merge(int[] arr, int[] auxArray, int low, int high, int mid)
        {
            int N = arr.Length;
            for (int k = 0; k < N; k++)
            {
                auxArray[k] = arr[k];
            }

            int i = low;
            int j = mid + 1;
            for (int k = low; k <= high; k++)
            {
                if (i > mid)
                {
                    arr[k] = auxArray[j++];
                }
                else if (j > high)
                {
                    arr[k] = auxArray[i++];
                }
                else if (auxArray[j] < auxArray[i])
                {
                    arr[k] = auxArray[j++];
                }
                else
                {
                    arr[k] = auxArray[i++];
                }
            }
        }

        private static void mergeEfficient(int[] arr, int l, int m, int r)
        {
            int p = l, q = m + 1;
            int[] res = new int[r - l + 1];
            int k = 0;

            for (int i = l; i <= r; i++)
            {
                if (p > m)
                    res[k++] = arr[q++];
                else if (q > r)
                    res[k++] = arr[p++];
                else if (arr[p] < arr[q])
                    res[k++] = arr[p++];
                else
                    res[k++] = arr[q++];
            }

            for (int i = 0; i < k; i++)
                arr[l++] = res[i];
        }

        public static void fnBinaryArraySorting2(int[] arr)
        {
            int[] auxArr = new int[2];
            for (int i = 0; i < arr.Length; i++)
            {
                auxArr[arr[i]]++;
            }

            for (int i = 0; i < 2; i++)
            {
                while (auxArr[i] != 0)
                {
                    Console.Write(i + " ");
                    auxArr[i]--;
                }
            }

            Console.WriteLine();
        }

        public static void fnBinaryArraySorting3(int[] arr)
        {
            int n = arr.Length;
            // To store result 
            int[] b = new int[n];
            int k = 0, l = n - 1, i, j;
            for (i = 0, j = n - 1; i < j; i++, j--)
            {

                if (arr[i] % 2 == 0)
                {
                    b[k] = arr[i];
                    k++;
                }
                else
                {
                    b[l] = arr[i];
                    l--;
                }

                if (arr[j] % 2 == 0)
                {
                    b[k] = arr[j];
                    k++;
                }
                else
                {
                    b[l] = arr[j];
                    l--;
                }
            }

            // for i == j in case of odd length 
            b[l] = arr[i];

            // Printing segregated array 
            for (i = 0; i < n; i++)
            {
                Console.Write(b[i] + " ");
            }

            Console.WriteLine();
        }

        public static void fnBinaryArraySorting(int[] arr)
        {
            int n = arr.Length;
            int numOfZeros = 0;

            for (int i = 0; i < n; i++)
            {
                if (arr[i] == 0)
                    numOfZeros++;
            }

            StringBuilder s = new StringBuilder();

            for (int i = 0; i < numOfZeros; i++)
            {
                s.Append(0 + " ");
            }

            for (int i = numOfZeros; i < n; i++)
            {
                s.Append(1 + " ");
            }

            Console.WriteLine(s.ToString());
        }
    }
}
