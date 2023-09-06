using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2_DotNet
{
    class ClassnInstance_Eg
    {
        public static void Main()
        {
            //creating object of the class
            ClassnInstance_Eg cobj = new ClassnInstance_Eg(); 
            ClassnInstance_Eg cobj2 = new ClassnInstance_Eg();
            Console.WriteLine(cobj.Add(5, 7)); // invoking an instance method //not static function so we use object to call 
            Console.WriteLine(cobj2.Add(10, 20));// invoking an instance method //not static function so we use object to call 
            staticEg.evenNos(4);  //invoking a class/static method that is in another class // if we use static then we dont want to add object to call the function
            oddNos(6); //invoking a class/static method that is within the same class
            Console.Read();
        }

        public int Add(int x, int y) // instance functions/methods
        {
            return x + y;
        }

        public static void oddNos(int x)
        {
            if (x % 2 != 0)
                Console.WriteLine("Number is Odd");
            else
                Console.WriteLine("Number is Even");
        }
    }

    class staticEg
    {
        public static void evenNos(int num) // static functions are known as class functions/methods
        {
            if (num % 2 == 0)
                Console.WriteLine("Number is an even Number");
            else
                Console.WriteLine("Number is an Odd Number");
        }
    }
}