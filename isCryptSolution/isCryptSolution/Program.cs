using System;

namespace isCryptSolution
{
    class Program
    {
        static void Main(string[] args)
        {
            char[][] solution1 =
            {
                new char[] {'O', '0'},
                new char[] {'M', '1'},
                new char[] {'Y', '2'},
                new char[] {'E', '5'},
                new char[] {'N', '6'},
                new char[] {'D', '7'},
                new char[] {'R', '8'},
                new char[] {'S', '9'},
            };
            String[] crypt1 = { "SEND", "MORE", "MONEY" };

            Console.WriteLine("Result = " + isCrypSolution(crypt1, solution1));
        }

        public static bool isCrypSolution(String[] crypt, char[][] solution)
        {
            String result1 = "";
            String result2 = "";
            String result3 = "";
            String word = "";
            for (int k = 0; k < crypt.Length; k++)
            {
                word = crypt[k];

                if (k == 0)
                {
                    result1 = decrypt(word, solution);
                    if (result1.Substring(0, 1) == "0" && result1.Length > 1)
                        return false;
                    // Console.WriteLine("I am here 1");
                }
                if (k == 1)
                {
                    result2 = decrypt(word, solution);
                    if (result2.Substring(0, 1) == "0" && result2.Length > 1)
                        return false;
                    // Console.WriteLine("I am here 2");
                }
                if (k == 2)
                {
                    result3 = decrypt(word, solution);
                    if (result3.Substring(0, 1) == "0" && result3.Length > 1)
                        return false;
                    // Console.WriteLine("I am here 3");
                }
            }
            if (Double.Parse(result3) == (Double.Parse(result1) + Double.Parse(result2)))
                return true;
            else
                return false;

        }
        public static String decrypt(String word, char[][] solution)
        {
            String result = "";
            foreach (var c in word)
            {
                for (int i = 0; i < solution.Length; i++)
                {
                    for (int j = 0; j < solution[i].Length; j++)
                    {

                        if (j == 0 && (c == solution[i][j]))
                        {
                            result = result + solution[i][j + 1];
                        }
                    }
                }
            }
            // Console.WriteLine("result=" + result);
            return result;
        }
    }
}
