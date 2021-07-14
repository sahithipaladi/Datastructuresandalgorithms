using System;

namespace DataStructuresAlgorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-------------------Algorithm Programs-----------------");
            Console.WriteLine("1.Permutation\n0.Exit");
            Console.WriteLine("Choose an option : ");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    //Permutation of a word
                    Console.WriteLine("Enter a string to permute : ");
                    string str = Console.ReadLine();
                    int start = 0, end = str.Length;
                    Permutation.PermuteRecursive(str, start, end - 1);
                    break;
                case 0:
                    break;
            }
        }
    }
}
        
    

