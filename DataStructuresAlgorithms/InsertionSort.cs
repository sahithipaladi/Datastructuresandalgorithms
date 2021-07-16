using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructuresAlgorithms
{
    class InsertionSort
    {
        public static void ReadInput()
        {
            Console.WriteLine("Enter size of the array : ");
            int size = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter elements of an array : ");
            string[] arr = new string[size];
            for (int i = 0; i < size; i++)
            {
                arr[i] = Console.ReadLine();
            }
            Insertion(arr, size);
        }
        private static void Insertion(string[] arr, int length)
        {
            for (int i = 1; i < length; i++)
            {
                for (int j = i; j > 0; j--)
                {
                    if (arr[j - 1].CompareTo(arr[j]) > 0)
                    {
                        Swap(arr, j, j - 1);
                    }
                    else
                        break;
                }
            }
            Console.WriteLine("After performing Insertion Sort : ");
            for (int i = 0; i < length; i++)
            {
                Console.Write(arr[i] + " ");
            }
        }
        public static void Swap(String[] a, int i, int j)
        {
            string temp;
            temp = a[i];
            a[i] = a[j];
            a[j] = temp;
        }
    }
}
