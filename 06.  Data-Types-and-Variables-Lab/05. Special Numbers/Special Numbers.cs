using System;

public class Special_Numbers
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
                int lastDigit = digits % 10;
                sum += lastDigit;
                digits = digits / 10;
            }

            if (sum == 5 || sum == 7  || sum == 11)
            {
                Console.WriteLine($"{num} -> True");
            }
            else
            {
                Console.WriteLine($"{num} -> False");
            }
        }
    }
}
