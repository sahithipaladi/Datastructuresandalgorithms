using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructuresAlgorithms
{
    class Anagram
    {
        public static void FindAnagram()
        {
            Console.WriteLine("Enter first string");
            string str1 = Console.ReadLine();
            Console.WriteLine("Enter second string");
            string str2 = Console.ReadLine();
            char[] ch1 = str1.ToLower().ToCharArray();
            char[] ch2 = str2.ToLower().ToCharArray();
            Array.Sort(ch1);
            Array.Sort(ch2);
            string val1 = new string(ch1);
            string val2 = new string(ch2);
            if (val1 == val2)
                Console.WriteLine("Both the strings are anagrams");
            else
                Console.WriteLine("Both the strings are not anagrams");

        }
    }
}
