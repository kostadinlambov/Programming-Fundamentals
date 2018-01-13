using System;

public class Blank_Receipt
{
    public static void Main()
    {
        PrintReceiptHeader();
        PrintReceipt();
        PrintReceiptFooter();
    }

    public static void PrintReceiptHeader()
    {
        Console.WriteLine("CASH RECEIPT");
        Console.WriteLine("------------------------------");
    }

    public static void PrintReceipt()
    {
        Console.WriteLine("Charged to____________________");
        Console.WriteLine("Received by___________________");
    }

    private static void PrintReceiptFooter()
    {
        Console.WriteLine("------------------------------");
        Console.WriteLine("\u00A9 SoftUni");
    }
}

