using System;
using System.Collections.Generic;

namespace firstNotRepeatingCharacter
{
    class Program
    {
        static void Main(string[] args)
        {
            String s = "ngrhhqbhnsipkcoqjyviikvxbxyphsnjpdxkhtadltsuxbfbrkof"; // Test string
            Console.WriteLine("Result: " + firstNotRepeatingCharacter(s));
        }

        public static char firstNotRepeatingCharacter(string s)
        {
            var character = new Dictionary<char, int>();
            // Iterate through the characters of string s and log its occurence(s) to dictionary.
            foreach (var c in s)
            {
                if (!character.ContainsKey(c))
                    character[c] = 1;
                else
                    character[c]++;
            }
            // Return the first key (non-repeating char in string) whose value is 1
            foreach (var elem in character)
            {
                if (elem.Value == 1)
                    return elem.Key;
            }
            return '_';
        }
    }
}
