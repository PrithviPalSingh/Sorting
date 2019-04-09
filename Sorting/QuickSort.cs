using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting
{
    class QuickSort
    {
        public static void fnQuickSort(int[] arr)
        {
            fnQucikSortInner(arr, 0, arr.Length - 1);
        }

        private static void fnQucikSortInner(int[] arr, int low, int high)
        {

            if (low >= high)
                return;

            int pivot = fnPartition(arr, low, high);
            fnQucikSortInner(arr, low, pivot - 1);
            fnQucikSortInner(arr, pivot + 1, high);
        }

        private static int fnPartition(int[] arr, int low, int high)
        {
            int n = arr.Length;
            int i = low;
            int j = high + 1;

            while (true)
            {
                while (arr[++i] < arr[low])
                {
                    if (i == high)
                        break;
                }

                while (arr[--j] > arr[low])
                {
                    if (j == low)
                        break;
                }

                if (i >= j)
                    break;

                Excahnge(arr, i, j);
            }

            Excahnge(arr, j, low);
            return j;
        }

        private static void Excahnge(int[] arr, int i, int j)
        {
            int temp = arr[i];
            arr[i] = arr[j];
            arr[j] = temp;
        }
    }
}
