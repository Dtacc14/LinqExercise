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
            //Complete every task using Method OR Query syntax. 
            //You may find that Method syntax is easier to use since it is most like C#
            //Every one of these can be completed using Linq and then printing with a foreach loop.
            //Push to your github when completed!

            Console.Write("Sum: ");
            numbers.Sum(x => x).ToString().ToList().ForEach(Console.Write); //TODO: Print the Sum of numbers
            Console.WriteLine();

            Console.Write("Average: ");
            numbers.Average(x => x).ToString().ToList().ForEach(Console.Write);  //TODO: Print the Average of numbers
            Console.WriteLine();

            Console.WriteLine("Ascending:");
            numbers.OrderBy(x => x).ToList().ForEach(Console.WriteLine);  //TODO: Order numbers in ascending order and print to the console

            Console.WriteLine("Descending:");
            numbers.OrderByDescending(x => x).ToList().ForEach(Console.WriteLine);  //TODO: Order numbers in decsending order adn print to the console

            Console.WriteLine("Greater than six:");
            numbers.Where(x => x > 6).ToList().ForEach(Console.WriteLine);  //TODO: Print to the console only the numbers greater than 6

            Console.WriteLine("Four Numbers:");  //TODO: Order numbers in any order (acsending or desc) but only print 4 of them **foreach loop only!**
            foreach (var num in numbers.Take(4))
            {
                Console.WriteLine(num);
            }

            Console.WriteLine("Fun new number list:");
            numbers.SetValue(25, 4); //TODO: Change the value at index 4 to your age, then print the numbers in decsending order
            numbers.OrderByDescending(x => x).ToList().ForEach(Console.WriteLine);
            Console.WriteLine();

            // List of employees ****Do not remove this****
            var employees = CreateEmployees();

            Console.WriteLine("Employee names starting with C or S:");
            employees.Where(x => x.FirstName[0] == 'C' || x.FirstName[0] == 'S').OrderBy(x => x.FirstName).ToList().ForEach(x => Console.WriteLine(x.FullName)); //TODO: Print all the employees' FullName properties to the console only if their FirstName starts with a C OR an S and order this in acesnding order by FirstName.
            Console.WriteLine();

            Console.WriteLine("Employees older than 26(by age):");
            employees.Where(x => x.Age > 26).OrderBy(x => x.Age).ToList().ForEach(x => Console.WriteLine(x.FullName));  //TODO: Print all the employees' FullName and Age who are over the age 26 to the console and order this by Age first and then by FirstName in the same result.
            Console.WriteLine();

            Console.Write("Sum of YOE for employees with more than 10 YOE: ");
            Console.WriteLine(employees.Where(x => x.YearsOfExperience <= 10 && x.Age > 35).Sum(x => x.YearsOfExperience)); //TODO: Print the Sum and then the Average of the employees' YearsOfExperience if their YOE is less than or equal to 10 AND Age is greater than 35
            Console.Write("Average YOE for employees with more than 10 YOE: ");
            employees.Where(x => x.YearsOfExperience <= 10 && x.Age > 35).Average(x => x.YearsOfExperience).ToString().ToList().ForEach(Console.Write);
            Console.WriteLine();
            Console.WriteLine();

            Console.Write("Updated list w/ employee added:");
            employees = employees.Append(new Employee ("David", "Taccetta", 25, 0)).ToList(); //TODO: Add an employee to the end of the list without using employees.Add()
            Console.WriteLine();
            foreach (var person in employees)
            {
                Console.WriteLine(person.FullName);
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
