using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresAlgorithms
{
    class BinarySearch
    {
        /// <summary>
        /// Binary Search of a word from the list
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="str"></param>
        /// <returns></returns>
        public static void ReadInput()
        {
            Console.WriteLine("Enter the size of the array : ");
            int size = Convert.ToInt32(Console.ReadLine());
            string[] array = new string[size];
            Console.WriteLine("Enter elements of array : ");
            for (int i = 0; i < size; i++)
            {
                array[i] = Console.ReadLine();
            }
            Console.WriteLine("Enter an element to search : ");
            string searchElement = Console.ReadLine();
            int index = BinarySearchOfWord(array, searchElement);
            if (index == -1)
                Console.WriteLine("Element is not present");
            else
                Console.WriteLine("Index of element in the array is : " + index);
        }
        private static int BinarySearchOfWord(string[] arr, string str)
        {
            int startPos = 0, endPos = arr.Length - 1;
            while (startPos <= endPos)
            {
                int mid = (startPos + (endPos - startPos)) / 2;
                int result = str.CompareTo(arr[mid]);
                if (result == 0)
                    return mid;
                if (result > 0)
                    startPos = mid + 1;
                else
                    endPos = mid - 1;
            }
            return -1;
        }
    }
}