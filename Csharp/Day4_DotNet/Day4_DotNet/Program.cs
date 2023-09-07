using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4_DotNet
{
    class Array_Eg
    {
        public void SingleDimensionArray()
        {
            Console.WriteLine("Enter the length of the array:");
            int length = int.Parse(Console.ReadLine());

            int[] arr = new int[length];

            for (int i = 0; i < length; i++)
            {
                Console.Write($"Enter element {i + 1}: ");
                arr[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("The length is: {0}", arr.Length);
            Array.Sort(arr);

            Console.WriteLine("Sorted array:");
            foreach (var element in arr)
            {
                Console.WriteLine(element);
            }

            Console.WriteLine("Array rank: " + arr.Rank);


        }
    }
    class Program 
    {
        static void Main(string[] args)
        {
     
            Array_Eg age = new Array_Eg();
            age.SingleDimensionArray();
            Console.ReadLine();
        }
    }
}
