using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace DataStructuresAlgorithms

{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-------------------Algorithm Programs-----------------");
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("1.Permutation\n2.Binary Search of word\n3.Insertion Sort\n4.Bubble Sort\n5.Merge Sort\n6.Anagrams\n7.Prime Numbers\n8.Guess a number\n0.Exit");
                Console.WriteLine("Choose an option : ");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        //Permutation of a word
                        Console.WriteLine("Enter a string to permute : ");
                        string str = Console.ReadLine();
                        int start = 0, end = str.Length - 1;
                        Permutation.PermuteRecursive(str, start, end);
                        break;
                    case 2:
                        BinarySearch.ReadInput();
                        break;
                    case 3:
                        InsertionSort.ReadInput();
                        break;
                    case 4:
                        BubbleSort.ReadInput();
                        break;
                    case 5:
                        MergeSort.ReadInput();
                        break;
                    case 6:
                        Anagram.FindAnagram();
                        break;
                    case 7:
                        PrimeNumbers.FindPrime();
                        break;
                    case 8:
                        FindNumber.ThinkNumber();
                        break;
                    case 0:
                        break;
                    default:
                        Console.WriteLine("Choose an valid option");
                        break;
                }
            }
        }
    }
}