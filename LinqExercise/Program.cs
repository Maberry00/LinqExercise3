using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqExercise
{
    class Program
    {
        //Static array of integers
        private static int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };

        static void Main(string[] args)
        {
            /*
             * 
             * Complete every task using Method OR Query syntax. 
             * You may find that Method syntax is easier to use since it is most like C#
             * Every one of these can be completed using Linq and then printing with a foreach loop.
             * Push to your github when completed!
             * 
             */

            //TODO: Print the Sum of numbers

            //int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };

            //Console.WriteLine(numbers.Sum());

            //foreach (var number in numbers)
            //{
            //    Console.WriteLine(number);
            //}

            //TODO: Print the Average of numbers

            //List<int> list = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };

            //Console.WriteLine(list.Average());

            //TODO: Order numbers in ascending order and print to the console

            //numbers.OrderBy(numbers => numbers).ToList().ForEach(numbers => Console.WriteLine(numbers.ToString()));

            //TODO: Order numbers in descending order and print to the console

            //numbers.OrderByDescending(numbers => numbers).ToList().ForEach(numbers => Console.WriteLine(numbers.ToString()));

            //TODO: Print to the console only the numbers greater than 6

            //numbers.Where(numbers => numbers > 6).ToList().ForEach(numbers => Console.WriteLine(numbers.ToString()));

            //TODO: Order numbers in any order (ascending or desc) but only print 4 of them **foreach loop only!**

            //var orderedList = numbers.OrderBy(x => x).Take(4);
            //foreach (var item in orderedList) 
            //{
            //    Console.WriteLine(item);
            //}

            //TODO: Change the value at index 4 to your age, then print the numbers in descending order

            //numbers.SetValue(26, 4);

            //var descWithAge = numbers.OrderByDescending(x => x);
            //foreach (var item in descWithAge)
            //{
            //    Console.WriteLine(item);
            //}

            // List of employees ****Do not remove this****
            var employees = CreateEmployees();

            //TODO: Print all the employees' FullName properties to the console only if their FirstName starts with a C OR an S and order this in ascending order by FirstName.

            //Console.WriteLine("All names that start with C or S: ");
            //employees.Where(x => x.FirstName.StartsWith('C') || x.FirstName.StartsWith('S')) 
            //    .OrderBy(x => x.FirstName)
            //    .ToList()
            //    .ForEach(x => Console.WriteLine(x.FullName));
            //Console.WriteLine();

            //TODO: Print all the employees' FullName and Age who are over the age 26 to the console and order this by Age first and then by FirstName in the same result.

            //Console.WriteLine("Employees over 26 year old:");

            //employees.Where(x => x.Age >26).OrderBy(x => x.Age).ThenBy(x => x.FirstName).ToList().ForEach(x => Console.WriteLine($"Full Name: {x.Fullname} Age: {x.Age}"));

            //TODO: Print the Sum of the employees' YearsOfExperience if their YOE is less than or equal to 10 AND Age is greater than 35.

            //Console.WriteLine("Sum of YOE: ");
            //int employeeSum = employees.Where(x => x.YearsOfExperience <= 10 && x.Age > 35).Sum(x => x.YearOfExperience);
            //Console.WriteLine(employeeSum);
            //Console.WriteLine();

            //TODO: Now print the Average of the employees' YearsOfExperience if their YOE is less than or equal to 10 AND Age is greater than 35.

            //Console.WriteLine("Average of YOE");
            //double employeeAvg = employees.Where(x => x.YearsOfExperience <= 10 && x.Age > 35).Average(x => x.YearsOfExperience);
            //Console.WriteLine(employeeAvg);
            //Console.WriteLine();

            //TODO: Add an employee to the end of the list without using employees.Add()

            employees = employees.Append(new Employee("First", "Last", 30, 10)).ToList();

            employees.Add(new Employee("Bob", "G", 37, 5));
            
            foreach (var item in employees)
            {
                Console.WriteLine(item.FullName);
            }

            Console.WriteLine();

            Console.ReadLine();
        }

        #region CreateEmployeesMethod
        private static List<Employee> CreateEmployees()
        {
            List<Employee> employees = new List<Employee>();
            employees.Add(new Employee("Cruz", "Sanchez", 25, 10));
            employees.Add(new Employee("Steven", "Bustamento", 56, 5));
            employees.Add(new Employee("Micheal", "Doyle", 36, 8));
            employees.Add(new Employee("Daniel", "Walsh", 72, 22));
            employees.Add(new Employee("Jill", "Valentine", 32, 43));
            employees.Add(new Employee("Yusuke", "Urameshi", 14, 1));
            employees.Add(new Employee("Big", "Boss", 23, 14));
            employees.Add(new Employee("Solid", "Snake", 18, 3));
            employees.Add(new Employee("Chris", "Redfield", 44, 7));
            employees.Add(new Employee("Faye", "Valentine", 32, 10));

            return employees;
        }
        #endregion
    }
}
