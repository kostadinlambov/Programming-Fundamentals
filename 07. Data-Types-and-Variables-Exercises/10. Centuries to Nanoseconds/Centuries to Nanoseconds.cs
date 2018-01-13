using System;
using System.Numerics;

public class Centuries_to_Nanoseconds
{
    public static void Main()
    {
        int centuries = int.Parse(Console.ReadLine());
        int years = centuries * 100;
        int days = (int)(years * 365.2422);
        long hours = days * 24;
        long minutes = hours * 60;
        long seconds = minutes * 60;
        BigInteger milliseconds = seconds * 1000;
        BigInteger microseconds = milliseconds * 1000;
        BigInteger nanoseconds = milliseconds * 1000000;

        Console.WriteLine($"{centuries} centuries = {years} years = " +
                          $"{days} days = {hours} hours = " +
                          $"{minutes} minutes = {seconds} seconds = " +
                          $"{milliseconds} milliseconds = {microseconds} microseconds = " +
                          $"{nanoseconds} nanoseconds");
    }
}