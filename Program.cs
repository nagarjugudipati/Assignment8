//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Assignment8
//{




//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("Employee Type:");
//            Console.WriteLine("1-HR");
//            Console.WriteLine("2-Admin");
//            Console.WriteLine("3-Software Developer");
//            Console.Write("Enter employee type: ");
//            int employeeType = int.Parse(Console.ReadLine());

//            int workingHours, workingDays, projectHandles, extras;

//            Console.Write("Enter working hours: ");
//            workingHours = int.Parse(Console.ReadLine());

//            Console.Write("Enter number of working days: ");
//            workingDays = int.Parse(Console.ReadLine());
//            if (employeeType == 1 || employeeType == 3)
//            {
//                Console.Write("Enter number of project handles: ");
//                projectHandles = int.Parse(Console.ReadLine());
//            }
//            else
//            {
//                projectHandles = 0;
//            }

//            if (employeeType == 3)
//            {
//                Console.Write("Enter number of extras: ");
//                extras = int.Parse(Console.ReadLine());
//            }
//            else
//            {
//                extras = 0;
//            }
//            decimal monthlySalary = CalculateMonthlySalary(employeeType, workingHours, workingDays, projectHandles, extras);

//            Console.WriteLine($"Monthly Salary: {monthlySalary:C}");
//        }

//        static decimal CalculateMonthlySalary(int employeeType, int workingHours, int workingDays, int projectHandles, int extras)
//        {
//            decimal salary = 0;

//            if (employeeType == 1) // HR
//            {
//                salary = workingHours * workingDays * 100 + projectHandles * 3000;
//            }
//            else if (employeeType == 2) // Admin
//            {
//                salary = workingHours * workingDays * 100;
//            }
//            else if (employeeType == 3) // Software Developer
//            {
//                salary = workingHours * workingDays * 100 + projectHandles * 3000 + extras * 2000;
//            }

//            return salary;
//        }
//    }
//}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace optional_parameters
{
    public class calc
    {

        public double Calculate(double projectHandles = 1, double extras = 0)
        {
            Console.WriteLine("Enter no.of working hours per day");
            int WorkingHours = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter no.of working Days in a month");
            int workingDays = int.Parse(Console.ReadLine());

            double result = WorkingHours * workingDays + projectHandles * 3000 + extras * 2000;
            return result;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            calc obj = new calc();
            Console.WriteLine("Please Enter your role");
            string role = Console.ReadLine();
            switch (role)
            {
                case "HR":
                    Console.WriteLine($"Monthly salary of the {role} is:\t" + obj.Calculate());
                    break;
                case "Admin":
                    Console.WriteLine("Please enter your projrctHandles");
                    int p1 = int.Parse(Console.ReadLine());
                    Console.WriteLine($"Monthly salary of the {role} is:\t" + obj.Calculate(p1));
                    break;
                case "SoftwareDeveloper":
                    Console.WriteLine("Please enter your projrctHandles");
                    int p2 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Please enter your extras");
                    int extras = int.Parse(Console.ReadLine());
                    Console.WriteLine($"Monthly salary of the {role} is:\t" + obj.Calculate(p2, extras));
                    break;
                default:
                    Console.WriteLine("please Enter valid role");
                    break;
            }
            Console.ReadKey();
        }
    }
}