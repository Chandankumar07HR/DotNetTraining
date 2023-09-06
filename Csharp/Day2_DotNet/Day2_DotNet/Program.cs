using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2_DotNet
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("enter your firstname");
            string fname = Console.ReadLine();
            Console.WriteLine("your name is " + fname);//concatination=[text + text]

            Console.WriteLine("your name is {0}", fname); //placeholder {0}

            Console.WriteLine("enter your last name");
            string lname = Console.ReadLine();
            Console.WriteLine("your last name is" + lname);

            // multiple place holder
            Console.WriteLine("your first name is{0} and your last name is{1}",fname,lname);//mutiple place holder

            //string interpolation to display data
            Console.WriteLine($"your first name is {fname}and your last name is{lname} ");
            myclass.MyFucntion();
            myclass.funt2();
            Console.Read();
        }

    }
    class myclass
    {
        public static void MyFucntion() //without adding the static we can not call this function in main function.
        {
            Console.WriteLine("hi there");

        }
        public static void funt2()
        {

        }
    }
}
