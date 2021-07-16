using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructuresAlgorithms
{
    class PrimeNumbers
    {
        public static void FindPrime()
        {
            int start = 0, end = 1000;
            int[] arr = new int[200];
            int k = 0;
            Console.WriteLine("The prime numbers between the rang {0} - {1} : ", start, end);
            for (int i = start; i <= end; i++)
            {
                if (i == 0 || i == 1)
                    continue;
                int flag = 1;
                for (int j = 2; j <= i / 2; j++)
                {
                    if (i % j == 0)
                    {
                        flag = 0;
                        break;
                    }
                }
                if (flag == 1)
                {
                    Console.Write(i + " ");
                    arr[k] = i;
                    k++;
                }
            }
            FindAllPalindromes(arr, k);
            Console.WriteLine();
            FindAllAnagrams(arr, k);
        }
        public static void FindAllPalindromes(int[] arr, int k)
        {
            Console.WriteLine("\n\nThe Prime Numbers that are Palindrome are : ");
            for (int i = 0; i < k; i++)
            {
                int reverse = Reverse(arr[i]);
                if (arr[i] == reverse && arr[i] > 10)
                    Console.Write(arr[i] + " ");
            }
        }
        public static int Reverse(int num)
        {
            int rev = 0;
            while (num != 0)
            {
                int remainder = num % 10;
                rev = rev * 10 + remainder;
                num /= 10;
            }
            return rev;
        }
        public static void FindAllAnagrams(int[] intArray, int k)
        {
            string[] strArray = Array.ConvertAll<int, string>(intArray, ele => ele.ToString());
            Console.WriteLine("The Prime Numbers that are Anagram are : ");
            for (int i = 0; i < k; i++)
                for (int j = i + 1; j < k; j++)
                    if (Anagram(strArray[i], strArray[j]))
                        Console.WriteLine(strArray[i] +
                        " is anagram of " + strArray[j]);
        }
        public static bool Anagram(string str1, string str2)
        {
            int numOfChar = 256;
            int[] count = new int[numOfChar];
            int i;
            for (i = 0; i < str1.Length && i < str2.Length; i++)
            {
                count[str1[i]]++;
                count[str2[i]]--;
            }
            if (str1.Length != str2.Length)
                return false;
            for (i = 0; i < numOfChar; i++)
                if (count[i] != 0)
                    return false;
            return true;
        }
    }
}
