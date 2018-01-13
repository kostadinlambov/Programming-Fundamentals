using System;

public class Employee_Data
{
    public static void Main()
    {
        var firstName = Console.ReadLine();
        var lastName = Console.ReadLine();
        var age = int.Parse(Console.ReadLine());
        var gender = Console.ReadLine();
        var personalIdNumber = long.Parse(Console.ReadLine());
        var uniqueEmployeeNumber = long.Parse(Console.ReadLine());

        Console.WriteLine($"First name: {firstName}");
        Console.WriteLine($"Last name: {lastName}");
        Console.WriteLine($"Age: {age}");
        Console.WriteLine($"Gender: {gender}");
        Console.WriteLine($"Personal ID: {personalIdNumber}");
        Console.WriteLine($"Unique Employee number: {uniqueEmployeeNumber}");
    }
}

