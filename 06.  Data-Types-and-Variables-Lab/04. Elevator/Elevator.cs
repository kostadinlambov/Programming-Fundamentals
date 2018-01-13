using System;

public class Elevator
{
    public static void Main()
    {
        int numberOfPeople = int.Parse(Console.ReadLine());
        int capcityOfElevator = int.Parse(Console.ReadLine());

        int numberOfCourses = (int)Math.Ceiling((double)numberOfPeople / capcityOfElevator);

        Console.WriteLine(numberOfCourses);
    }
}