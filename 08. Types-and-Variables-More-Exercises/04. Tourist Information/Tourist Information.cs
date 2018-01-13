using System;

public class Tourist_Information
{
    public static void Main()
    {
        var imperialUnits = Console.ReadLine();
        var value = decimal.Parse(Console.ReadLine());

        var miles = 1.6m;
        var inches = 2.54m;
        var feet = 30m;
        var yards = 0.91m;
        var gallons = 3.8m;

        switch (imperialUnits)
        {
            case "miles":
                var kilometers = value * miles;
                Console.WriteLine($"{value} miles = {kilometers:f2} kilometers");
                break;
            case "inches":
                var centimeters = value * inches;
                Console.WriteLine($"{value} inches = {centimeters:f2} centimeters");
                break;
            case "feet":
                centimeters = value * feet;
                Console.WriteLine($"{value} feet = {centimeters:f2} centimeters");
                break;
            case "yards":
                var maters = value * yards;
                Console.WriteLine($"{value} yards = {maters:f2} meters");
                break;
            case "gallons":
                var liters = value * gallons;
                Console.WriteLine($"{value} gallons = {liters:f2} liters");
                break;
        }
    }
}