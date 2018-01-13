using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.Andrey_and_Billiard
{

    class Customer
    {
        public string Name { get; set; }

        public Dictionary<string, int> Shoplist { get; set; }

        public decimal Bill(string customerName, Dictionary<string, int> shop)
        {
            var bill = Shoplist[customerName] * shop[customerName];
            return bill;
        }

        public decimal Bill(decimal quantity, decimal itemPrice)
        {
            var bill = quantity * itemPrice;
            return bill;
        }
    }

    public class Andrey_and_Billiard
    {
        public static void Main()
        {
            var separators = new char[] { '-', ',' };
            var shop = new Dictionary<string, decimal>();

            var numberOfEntities = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfEntities; i++)
            {
                var amountOfEntitiesAndPrices = Console.ReadLine()
                    .Trim()
                    .Split(separators, StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                if (!shop.ContainsKey(amountOfEntitiesAndPrices[0]))
                {
                    shop[amountOfEntitiesAndPrices[0]] = 0;
                }

                shop[amountOfEntitiesAndPrices[0]] = decimal.Parse(amountOfEntitiesAndPrices[1]);
            }

            var order = Console.ReadLine();
            var listOfCustomers = new List<Customer>();

            while (order != "end of clients")
            {
                var token = order
                    .Split(separators, StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                var shoplist = new Dictionary<string, int>();
                var customer = new Customer
                {
                    Name = token[0],
                    Shoplist = shoplist
                };

                if (shop.ContainsKey(token[1]))
                {
                    if (!listOfCustomers.Any(a => a.Name == token[0]))
                    {
                        if (!shoplist.ContainsKey(token[1]))
                        {
                            shoplist[token[1]] = 0;
                        }

                        shoplist[token[1]] += int.Parse(token[2]);
                        listOfCustomers.Add(customer);
                    }
                    else
                    {
                        customer = listOfCustomers.First(a => a.Name == token[0]);
                        shoplist = customer.Shoplist;

                        if (!shoplist.ContainsKey(token[1]))
                        {
                            shoplist[token[1]] = 0;
                        }

                        shoplist[token[1]] += int.Parse(token[2]);
                    }
                }

                order = Console.ReadLine();
            }

            var totalBillCustomer = 0m;
            var totalBill = 0m;

            var sortedListOfCostumers = listOfCustomers
                .OrderBy(x => x.Name);

            foreach (var customer in sortedListOfCostumers)
            {
                Console.WriteLine(customer.Name);

                foreach (var name in customer.Shoplist)
                {
                    Console.WriteLine($"-- {name.Key} - {name.Value}");
                    var bill = customer.Bill(name.Value, shop[name.Key]);
                    totalBill += bill;
                    totalBillCustomer += bill;
                }

                Console.WriteLine($"Bill: {totalBillCustomer:f2}");
                totalBillCustomer = 0;
            }

            Console.WriteLine($"Total bill: {totalBill:f2}");
        }
    }
}
