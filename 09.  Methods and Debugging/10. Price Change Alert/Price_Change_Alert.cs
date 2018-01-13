using System;

public class Price_Change_Alert
{
    public static void Main()
    {
        int numberOfStockPrices = int.Parse(Console.ReadLine());
        double threshold = double.Parse(Console.ReadLine());
        double lastPrice = double.Parse(Console.ReadLine());

        for (int i = 0; i < numberOfStockPrices - 1; i++)
        {
            double currentPrice = double.Parse(Console.ReadLine());
            double currentProcentage = GetProcentage(lastPrice, currentPrice);
            bool hasDifference = HasDifference(currentProcentage, threshold);

            string message = GetNotification(currentPrice, lastPrice, currentProcentage, hasDifference, threshold);
            Console.WriteLine(message);

            lastPrice = currentPrice;
        }
    }

    public static string GetNotification(double currentPrice, double lastPrice, double difference, bool eitherTrueOrFalse, double limit)
    {
        string result = string.Empty;
        if (difference == 0)
        {
            result = string.Format("NO CHANGE: {0}", currentPrice);
        }
        else if (!eitherTrueOrFalse)
        {
            result = string.Format("MINOR CHANGE: {0} to {1} ({2:F2}%)", lastPrice, currentPrice, difference * 100);
        }
        else if (eitherTrueOrFalse && (difference > 0))
        {
            result = string.Format("PRICE UP: {0} to {1} ({2:F2}%)", lastPrice, currentPrice, difference * 100);
        }
        else if (eitherTrueOrFalse && (difference < 0))
        {
            result = string.Format("PRICE DOWN: {0} to {1} ({2:F2}%)", lastPrice, currentPrice, difference * 100);
        }

        return result;
    }

    public static bool HasDifference(double limit, double currentProcentage)
    {
        if (Math.Abs(limit) >= currentProcentage)
        {
            return true;
        }

        return false;
    }

    public static double GetProcentage(double lastPrice, double currentPrice)
    {
        return (currentPrice - lastPrice) / lastPrice;
    }
}
