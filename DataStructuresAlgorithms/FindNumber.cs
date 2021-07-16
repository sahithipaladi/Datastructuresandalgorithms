using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructuresAlgorithms
{
    class FindNumber
    {
        /// <summary>
        /// Guessing a number 
        /// </summary>
        public static int startPoint = 1, endPoint = 100;
        public static bool isFound = false;
        public static int FindMid()
        {
            int mid = (startPoint + endPoint) / 2;
            return mid;
        }
        public static void ReadInput(int mid)
        {
            Console.WriteLine("\n1-Is your number {0}?\n2-Is your number less than {0}?\n3-Is your number Greater than {0}?", mid);
            Console.WriteLine("Enter your choice : ");
            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    Console.WriteLine("Guessing Number Found " + mid);
                    isFound = true;
                    break;
                case 2:
                    endPoint = mid - 1;
                    break;
                case 3:
                    startPoint = mid + 1;
                    break;
                default:
                    Console.WriteLine("Invalid choice...");
                    break;
            }
        }
        public static void ThinkNumber()
        {
            Console.WriteLine("Assume number between {0} -{1}", startPoint, endPoint);
            while (startPoint != endPoint && isFound == false)
            {
                int mid = FindMid();
                ReadInput(mid);
            }
            if (startPoint == endPoint)
                Console.WriteLine("Guessing Number Found " + startPoint);
        }
    }
}
