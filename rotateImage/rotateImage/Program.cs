using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rotateImage
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            int[][] i = new int[2][];
            i[0] = new int[3] { 1, 2, 3 };
            i[1] = new int[2] { 4, 5 };
            */

            int[][] matrix = new int[][]
            {
                  new int[] { 1, 2, 3 },
                  new int[] { 4, 5, 6 },
                  new int[] { 7, 8, 9 }
            };
            print(matrix, "Before");
            
            int[][] rotated = rotate2DMatrix(matrix);
            print(rotated, "After");
        }

        public static int[][] rotate2DMatrix(int[][] m)
        {
            // need a temp array to store the work. This is still O(1) "additional" memory.   
            int[][] rotate = new int[m[0].Length][];

            // have to initialize each row in temp, because it's technically a jagged array.
            for (int row = 0; row < m[0].Length; row++)
            {
                rotate[row] = new int[m[0].Length];
            }

            // transpose the matrix by swapping rows and columns
            for (int row = 0; row < m[0].Length; row++)
            {
                for (int column = 0; column < m[0].Length; column++)
                {
                    rotate[column][row] = m[row][column];
                }
            }

            // now reverse all the rows
            for (int row = 0; row < m[0].Length; row++)
            {
                rotate[row] = rotate[row].Reverse().ToArray();
            }
            // that's it. 
            return rotate;
        }

        public static void print(int[][] matrix, string message)
        {
            Console.WriteLine(message);
            foreach (var a in matrix)
            {
                foreach (var i in a)
                {
                    Console.Write("{0,3}", i);
                }
                Console.WriteLine();
            }
        }
    }
}
