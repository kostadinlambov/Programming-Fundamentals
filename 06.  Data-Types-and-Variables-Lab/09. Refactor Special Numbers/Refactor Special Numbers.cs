using System;

public class Refactor_Special_Numbers
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());
   
        for (int num = 1; num <= n; num++)
        {
            int sum = 0;
            int digits = num;
            while (digits > 0)
            {
                sum += digits % 10;
                digits = digits / 10;
            }

            bool special = (sum == 5) || (sum == 7) || (sum == 11);

            Console.WriteLine($"{num} -> {special}"); 
        }
    }
}

