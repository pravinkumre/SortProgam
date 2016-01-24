using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace SortingProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] unsorted = { "AnaNt", "Anand", "Ram", "Ra1", "Zebra", "Z9$", "z1.."};
          
            Console.WriteLine("-- Unsorted array elements --");

            // Print the unsorted string array
            foreach( string element in unsorted)
            {
                Console.WriteLine(element);
            };

            Console.WriteLine();

            // Sort the string array
            Quicksort(unsorted, 0, unsorted.Length - 1);

            Console.WriteLine("-- Sorted array elements --");

            // Print the sorted string array
            foreach (string element in unsorted)
            {
                Console.WriteLine(element);
            };

            Console.WriteLine();

            Console.ReadLine();
        }

        public static void Quicksort(string[] elements, int left, int right)
        {
            int i = left, j = right;

            string pivot = elements[(left + right) / 2];

            while (i <= j)
            {
                while (elements[i].CompareTo(pivot) < 0)
                {
                    i++;
                }

                while (elements[j].CompareTo(pivot) > 0)
                {
                    j--;
                }

                if (i <= j)
                {
                    // Swap using temp variable
                    string tmp = elements[i];
                    elements[i] = elements[j];
                    elements[j] = tmp;

                    i++;
                    j--;
                }
            }

            // Recursive calls
            if (left < j)
            {
                Quicksort(elements, left, j);
            }

            if (i < right)
            {
                Quicksort(elements, i, right);
            }

        }
    }
}
