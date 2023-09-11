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
        protected float total;
        internal protected string adress;

        public void accept()
        {
            Id = 20;
            Sname = "chandan";
            total = 90;
        }

        
    }
    class Program : AccessSpecifier_Eg
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

            // protected example
            // for protected fields to be accessed we need to inherit the parent class here ie assessspecifier and nect we need to  create a object of this class means chlid class ie here Program class and using object we can acess protected field.
            Program ag3 = new Program();
            ag3.total = 90;

            //internal protected = internal protected field can be access in different class also by inheriting the parent class and creating the object of the parent class and then using object we can call.
            ag.adress = "kadur"; // because it has internal it can access by using the parent class name inside the assembly

            ag3.adress = "chowlahiriyur"; // here using the child class object also it is acessable because child class is derived



            // for example the field is static we dont want to create the object of that class we can directly access by using just the class.
            //AccessSpecifier_Eg.Sname = "chandan";
            

        }
    }
}
