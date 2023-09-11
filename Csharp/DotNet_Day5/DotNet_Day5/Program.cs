using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNet_Day5
{
    public class AccessSpecifier_Eg
    {
        private int Id;
        public  string Sname;
       // public static string Sname; ex: if we make field as static 
        internal float Marks;

        public void accept()
        {
            Id = 20;
            Sname = "chandan";
        }

        
    }
    class Program 
    {
        static void Main(string[] args)
        {
            AccessSpecifier_Eg ag = new AccessSpecifier_Eg();
            //ex of public fields ie Sname 
            //Console.WriteLine("enter the name"); 
            //ag.Sname= "chandan" or 
            ag.Sname = Console.ReadLine();//this is input taken by the user // or ag.Sname= "chandan" this is we are assigning value to the field by using the object
            Console.WriteLine( "the name is "+ag.Sname); // or just Console.Writeline("ag.Same") this is for we assigning value
            Console.ReadLine();

            // internal example 
            ag.Marks = 70;


            // for example the field is static we dont want to create the object of that class we can directly access by using just the class.
            //AccessSpecifier_Eg.Sname = "chandan";
            

        }
    }
}
