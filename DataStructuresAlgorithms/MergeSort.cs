using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructuresAlgorithms
{
    class MergeSort
    {
        public static void ReadInput()
        {
            Console.WriteLine("Enter size of the array : ");
            int size = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter elements of an array : ");
            int[] arr = new int[size];
            for (int i = 0; i < size; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            Bubble(arr, size);
        }
        private static void Bubble(int[] arr, int length)
        {
            for (int i = 0; i < length - 1; i++)
            {
                for (int j = 0; j < length - i - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }
            Console.WriteLine("The elements in an array after Bubble sort : ");
            for (int i = 0; i < length; i++)
                Console.WriteLine(arr[i] + " ");
        }
    }
}
    

