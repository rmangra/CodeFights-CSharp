using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace firstDuplicate
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = { 8, 4, 6, 2, 6, 4, 7, 9, 5, 8 }; // Test Arrays
            // int[] a = { 1, 1, 2, 2, 1 }; // Test Arrays
            Console.WriteLine("Result: " + firstDuplicate1(a));
        }

        /* firstDuplicate1:
         * 
         * This was the first attempt at a minimum viable solution.
         * This solution utilizes nested loops to iterate through the array elements 
         * and perform comparison operators to determine the index of the first duplicate.
         * This is a O(n^2) solution because it traverses the array elements more than once.
         * Although this approach passes 20/22 test cases, it fails on the execution time
         * constraint and O(n) constraint. 
         */

        public static int firstDuplicate1(int[] a)
        {
            int mindupindex = -1;
            for (int i = 0; i < a.Length; i++)
            {
                for (int j = i + 1; j < a.Length; j++)
                {
                    if (a[i] == a[j])
                    {
                        if (j < mindupindex)
                            mindupindex = j;
                        else
                        {
                            if (mindupindex == -1)
                                mindupindex = j;
                        }
                    }

                }
            }
            if (mindupindex == -1)
                return -1;
            else
                return a[mindupindex];
        }
    }
}
