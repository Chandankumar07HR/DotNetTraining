// 1.Write a C# Sharp program to accept two integers and check whether they are equal or not. 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input the first number:");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("the first number is" + num1);

            Console.WriteLine("Inpput 2nd number:");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("the second number is" + num2);

            if (num1 == num2)
            {
                Console.WriteLine($"{num1} and {num2} are equal");

            }
            else
                Console.WriteLine($"{num1} and {num2} are not equal");
            Program.negative(); //calling nagative() function in main function and the function negative is static so i dont want to create object and the negative function is in same class as of main.
            Console.ReadLine();

        }
    //2. Write a C# Sharp program to check whether a given number is positive or negative.
        static void negative()
        {
            int number = 14;
            if(number > 0)
            {
                Console.WriteLine($"{number} is a positive number");
            }
            else if(number < 0)
            {
                Console.WriteLine($"{number} is a negative number");
            }
        }

    }
}
