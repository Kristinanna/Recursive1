using System;
using System.Collections.Generic;
using System.Linq;

namespace Recursive1
{
    class Program
    {
        static int Private(string[] args)
        {


            bool is_increasing(int[] arr, int n)
            {
                if (n == 1  n == 0)
                        {

                return 1;
            }

            if (arr[n - 1] < arr[n - 2])
            {

                return 0;
            }

            return is_increasing(arr, n - 1);

            int[] arr = { 1, 2, 3, 4 };
            int n = arr.Length;

            if (is_increasing(arr, n) != 0)
            {
              Console.WriteLine("true");
            }

            else
            {
                Console.WriteLine("false");
            }

            static int is_increasing(int[] arr, int n)
                

            if (n == 1  n == 0)
                    {
                return 1;
            }

            if (arr[n - 1] < arr[n - 2])
            {
                return 0;
            }

            return is_increasing(arr, n - 1);
        
        }

    }
}


