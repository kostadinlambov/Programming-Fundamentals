﻿namespace _3.Employee_Data
{
    using System;

    public class Program
    {
        public static void Main()
        {
            var name = Console.ReadLine();
            var age = int.Parse(Console.ReadLine());
            var employeeID = int.Parse(Console.ReadLine());
            var monthlySalary = decimal.Parse(Console.ReadLine());

            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Age: {age}");
            Console.WriteLine($"Employee ID: {employeeID:D8}");
            Console.WriteLine($"Salary: {monthlySalary:F2}");
        }
    }
}
