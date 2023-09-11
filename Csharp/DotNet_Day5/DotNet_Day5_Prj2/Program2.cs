using System;
using DotNet_Day5;

namespace DotNet_Day5_Prj2
{
    class Program2:AccessSpecifier_Eg
    {
        static void Main(string[] args)
        {
            AccessSpecifier_Eg ag2 = new AccessSpecifier_Eg();
            ag2.Sname = "bharath";
            Console.WriteLine(ag2.Sname);
            Console.ReadLine();

            //protected example
            //create a object of child class tht is program2 here
            Program2 p2 = new Program2();
            p2.total = 350;

            // internal we cannot accessable in different accembly but protected we can access if and only if we derive child class so internal protected field can be accessable outside assembly because it has protected so we have child class objecct derived
            p2.adress = "chowlahiriyur";
            // here we cannot use parent class object to access internal protected field becuase it has internal so outside assembly we cannot but if we use child class object we can access the same field.
            

        }
    }
}
