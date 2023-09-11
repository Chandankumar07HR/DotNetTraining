using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNet_Day4
{
    class Employee
    {
        int EmpId;
        string EmpName;
        DateTime DOJ;
        Double Salary;
        //1 constructor 
        // constructor should 
        public Employee() //this constructore has no parameters inside the function
        {
            Console.WriteLine("Hello from Employee");
        }
        // 2) we can overload the constructor by varieing in the parametrs ex: int empid, double slary,
        public Employee(int empid, double salary) // this constuctor has 2 parameter inside the function
        {
            EmpId = empid;
            Salary = salary;
        }
        // we can overload by giving one paramter in one constuctor and 2 or 3 or 0 in another consturtor
        public Employee(int EmpId, string EmpName, DateTime DOJ, double sal)
        {
            this.EmpId = EmpId;
            this.EmpName = EmpName;
            this.DOJ = DOJ;
            Salary = sal;
        }
        public void Accept()
        {
            Console.WriteLine("Enter Employee ID,Name,DOJ and Salary :");
            EmpId = Convert.ToInt32(Console.ReadLine());
            EmpName = Console.ReadLine();
            DOJ = Convert.ToDateTime(Console.ReadLine());
            Salary = Convert.ToDouble(Console.ReadLine());
        }

        public void ShowDetails()
        {
            Console.WriteLine("Employee Details .........");
            Console.WriteLine($"Employee ID is :{EmpId} Name is { EmpName}, Date of Joining is {DOJ} " +
                $"and Salary Earned is {Salary}"
                );
        }
        //public void chandan()
        //{
        //    Console.WriteLine("chandan");
        //}

        //destructor
        ~Employee()
        {
            Console.WriteLine("bye from employee");
        }

    }
}