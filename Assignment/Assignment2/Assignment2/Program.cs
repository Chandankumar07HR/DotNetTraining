//Write a  Program to assign integer values to an array  and then print the following
//a.	 Average value of Array elements
//b.Minimum and Maximum value in an array
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] numbers = { 5, 12, 7, 15, 3 };

            double average = numbers.Average();

            int min = numbers.Min();
            int max = numbers.Max();

            Console.WriteLine("Array Elements: " + string.Join(", ", numbers));

            Console.WriteLine("Average Value: " + average);

            Console.WriteLine("Minimum Value: " + min);

            Console.WriteLine("Maximum Value: " + max);
            Console.ReadLine();
            Program.secondprogram();

        }
        static void secondprogram()
        {
            int[] marks = new int[10];

            // Accepting ten marks from the user
            for (int i = 0; i < 10; i++)
            {
                Console.Write("Enter mark {0}: ", i + 1);
                marks[i] = int.Parse(Console.ReadLine());
            }

            // Calculating total and average
            int total = marks.Sum();
            double average = (double)total / 10;

            // Finding minimum and maximum marks
            int minMark = marks.Min();  
            int maxMark = marks.Max();

            // Sorting marks in ascending order
            int[] ascendingMarks = marks.OrderBy(mark => mark).ToArray();

            // Sorting marks in descending order
            int[] descendingMarks = marks.OrderByDescending(mark => mark).ToArray();

            // Displaying the results
            Console.WriteLine("1) Total: " + total);
            Console.WriteLine("2) Average: " + average);
            Console.WriteLine("3) Minimum Marks: " + minMark);
            Console.WriteLine("4) Maximum Marks: " + maxMark);

            Console.WriteLine("5) Marks in Ascending Order:");
            foreach (int mark in ascendingMarks)
            {
                Console.Write(mark + " ");
            }
            Console.WriteLine();

            Console.WriteLine("6) Marks in Descending Order:");
            foreach (int mark in descendingMarks)
            {
                Console.Write(mark + " ");
            }
            Console.ReadLine();
        }

    }
}