using System;

namespace sudoku2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Valid (true) test grid 
            char[][] grid1 = new char[][]
            {
                new char[] {'.', '.', '.', '1', '4', '.', '.', '2', '.'},
                new char[] {'.', '.', '6', '.', '.', '.', '.', '.', '.'},
                new char[] {'.', '.', '.', '.', '.', '.', '.', '.', '.'},
                new char[] {'.', '.', '1', '.', '.', '.', '.', '.', '.'},
                new char[] {'.', '6', '7', '.', '.', '.', '.', '.', '9'},
                new char[] {'.', '.', '.', '.', '.', '.', '8', '1', '.'},
                new char[] {'.', '3', '.', '.', '.', '.', '.', '.', '6'},
                new char[] {'.', '.', '.', '.', '.', '7', '.', '.', '.'},
                new char[] {'.', '.', '.', '5', '.', '.', '.', '7', '.'}
            };
            
            // Invalid (false) test grid
            char[][] grid2 = new char[][]
            {
                new char [] {'.', '.', '.', '.', '2', '.', '.', '9', '.'},
                new char [] {'.', '.', '.', '.', '6', '.', '.', '.', '.'},
                new char [] {'7', '1', '.', '.', '7', '5', '.', '.', '.'},
                new char [] {'.', '7', '.', '.', '.', '.', '.', '.', '.'},
                new char [] {'.', '.', '.', '.', '8', '3', '.', '.', '.'},
                new char [] {'.', '.', '8', '.', '.', '7', '.', '6', '.'},
                new char [] {'.', '.', '.', '.', '.', '2', '.', '.', '.'},
                new char [] {'.', '1', '.', '2', '.', '.', '.', '.', '.'},
                new char [] {'.', '2', '.', '.', '3', '.', '.', '.', '.'}
            };

            printBoard(grid1);
            Console.WriteLine("Result: " + sudoku2(grid1));

            printBoard(grid2);
            Console.WriteLine("Result: " + sudoku2(grid2));
        }
        
        public static bool sudoku2(char[][] grid)
        {
            int glength = grid.Length;
            for (int i = 0; i < glength; i++)
            {
                for (int j = 0; j < grid[i].Length; j++)
                {
                    if (grid[i][j] != '.' && !checkSudoku(grid, i, j, glength))
                        return false;
                }
            }
            return true;
        }

        public static bool checkSudoku(char[][] grid, int x, int y, int glength)
        {
            for (int i = 0; i < glength; i++)
            {
                if (grid[x][y] == grid[i][y] && x != i || grid[x][y] == grid[x][i] && y != i)
                {
                    return false;
                }
            }
            int a = x / 3, b = y / 3;
            a *= 3;
            b *= 3;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (grid[a + i][b + j] == grid[x][y] && (a + i != x && b + j != y))
                        return false;
                }
            }
            return true;
        }
        
        // Method to print contents of the Sudoku board
        public static void printBoard(char[][] sudoku)
        {
            for (int i = 0; i < sudoku.Length; i++)
            {
                Console.Write("\n");
                if (i % 3 == 0)
                    Console.Write("\n");
                for (int j = 0; j < sudoku.Length; j++)
                {
                    if (j % 3 == 0)
                        Console.Write(" ");
                    if (sudoku[i][j] == '.')
                        Console.Write(". ");
                    if (sudoku[i][j] == '1')
                        Console.Write("1 ");
                    if (sudoku[i][j] == '2')
                        Console.Write("2 ");
                    if (sudoku[i][j] == '3')
                        Console.Write("3 ");
                    if (sudoku[i][j] == '4')
                        Console.Write("4 ");
                    if (sudoku[i][j] == '5')
                        Console.Write("5 ");
                    if (sudoku[i][j] == '6')
                        Console.Write("6 ");
                    if (sudoku[i][j] == '7')
                        Console.Write("7 ");
                    if (sudoku[i][j] == '8')
                        Console.Write("8 ");
                    if (sudoku[i][j] == '9')
                        Console.Write("9 ");
                }
            }
            Console.WriteLine("");
        }
    }
}

