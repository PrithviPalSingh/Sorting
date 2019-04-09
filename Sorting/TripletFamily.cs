using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting
{
    class TripletFamily
    {
        public static void fnTripletFamily(int[] arr)
        {
            Array.Sort(arr);
            int n = arr.Length;
            int count = 0;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    var num = arr[i] + arr[j];
                    if (BinarySearch(arr, num, j + 1, n - 1) != -1)
                    {
                        count++;
                    }
                }
            }

            if(count!=0)
                Console.WriteLine(1);
            else
                Console.WriteLine(-1);
        }

        private static int BinarySearch(int[] arr, int k, int low, int high)
        {
            if (low > high)
                return -1;

            int mid = (low + high) / 2;

            if (arr[mid] == k)
                return 1;

            if (arr[mid] > k)
                return BinarySearch(arr, k, low, mid - 1);

            return BinarySearch(arr, k, mid + 1, high);


        }
    }
}
