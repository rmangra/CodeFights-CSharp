using System;
using System.Collections.Generic;

namespace firstDuplicate
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = { 8, 4, 6, 2, 6, 4, 7, 9, 5, 8 }; // Test Arrays
            // int[] a = { 1, 1, 2, 2, 1 }; // Test Arrays
            Console.WriteLine("Result: " + firstDuplicate3(a));
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

        /* firstDuplicate2:
         * 
         * This solution utilizes a HashSet data structure.
         * A HashSet does not contain duplicate elements, but its elements are not
         * stored in a particular order.
         * This is an O(n) solution because it iterates through the array once or
         * at least until the first duplicate is found.
         * It passes all test cases (22/22).
         * 
         * MSDN HashSet<T> Class Documentation:
         * https://msdn.microsoft.com/en-us/library/bb359438(v=vs.110).aspx
         */

        public static int firstDuplicate2(int[] a)
        {
            HashSet<int> numbers = new HashSet<int>();
            for (int i = 0; i < a.Length; i++)
            {
                if (numbers.Contains(a[i]))
                    return a[i];
                else
                    numbers.Add(a[i]);
            }
            return -1;
        }

        /* firstDuplicate3:
         * 
         * This solution utilizes a Dictionary data structure.
         * A Dictionary is a collection of key-value pairs.
         * This algorithm is more robust because it can be extended to provide a solution to other
         * similiar cases. For example, if you wanted to track the occurrences of an element in the array. 
         * This is an O(n) solution because it iterates through the array once or
         * at least until the first duplicate is found.
         * It passes all test cases (22/22).
         * 
         * MSDN Dictionary<TKey, TValue> Class Documentation: 
         * https://msdn.microsoft.com/en-us/library/xfhwa508(v=vs.110).aspx
         */

        public static int firstDuplicate3(int[] a)
        {
            Dictionary<int, int> numbers = new Dictionary<int, int>();
            for (int i = 0; i < a.Length; i++)
            {
                if (numbers.ContainsKey(a[i]))
                    return a[i];
                else
                    numbers.Add(a[i], 1);
            }
            return -1;
        }
    }
}
