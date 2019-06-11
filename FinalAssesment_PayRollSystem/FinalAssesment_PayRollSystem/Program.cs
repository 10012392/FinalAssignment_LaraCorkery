//Lara Corkery 10012392 (11/06/2019)
//Final Assignment (PayRoll System) Program Two 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalAssesment_PayRollSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            //Introduction to application 
            Console.WriteLine("---------------------------------------------------");
            Console.WriteLine("--- Welcome To The Rotorua Thermal Holiday Park ---");
            Console.WriteLine("---------------- Employee PayRoll -----------------");
            Console.WriteLine("---------------------------------------------------");

            //Asks User To Input Employee information 
            Console.WriteLine("Please Enter Employee's First And Last Name: ");
            string name = Console.ReadLine();
            Console.WriteLine($"Please Enter {name}'s Annual Gross Salary: ");
            double salary = double.Parse(Console.ReadLine());
            Console.WriteLine($"Please Enter {name}'s Tax Rate: ");
            double tax = double.Parse(Console.ReadLine());

            //Employee object (constructor & populating) with variables with saved employee information 
            Employee p1 = new Employee(name, salary, tax);
            Console.WriteLine("Employee Recorded And Created");
            Console.ReadLine();

            //Display the employee information 
            Console.WriteLine($"Name: {p1.Name} \nAnnual Gross Salary: {p1.Salary} \nTax Rate: {p1.Tax}% \nNet Salary: {p1.CalcNet()} ");
            Console.ReadLine();

            

        }

        class Employee
        {
            //Three properties implemented
            public string Name { get; set; }
            public double Salary { get; set; }
            public double Tax { get; set; }

            public Employee(string _name, double _salary, double _tax)
            {
                Name = _name;
                Salary = _salary;
                Tax = _tax;
            }
            //Method that calulates the employee net salary 
            public double CalcNet()
            {
                return Salary * (1 - Tax / 100);
            }

        }
    }
}
