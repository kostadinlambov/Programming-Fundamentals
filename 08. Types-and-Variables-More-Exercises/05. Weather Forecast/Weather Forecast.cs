using System;

public class Weather_Forecast
{
    public static void Main()
    {
        var inputNumber = Console.ReadLine();

        try
        {
            long integerNumber = long.Parse(inputNumber);

            if (integerNumber >= sbyte.MinValue && integerNumber <= sbyte.MaxValue)
            {
                Console.WriteLine("Sunny");
            }
            else if (integerNumber >= int.MinValue && integerNumber <= int.MaxValue)
            {
                Console.WriteLine("Cloudy");
            }
            else if (integerNumber >= long.MinValue && integerNumber <= long.MaxValue)
            {
                Console.WriteLine("Windy");
            }
        }
        catch 
        {
            Console.WriteLine("Rainy");          
        }     
    }
}