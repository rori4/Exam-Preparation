using System;
using System.Globalization;

namespace Coffee_Orders
{
    class CoffeeOrdersProgram
    {
        static void Main()
        {
            int num = int.Parse(Console.ReadLine());
            decimal sum = 0;
            for (int i = 0; i < num; i++)
            {
                decimal price = decimal.Parse(Console.ReadLine());
                DateTime date = DateTime.ParseExact(Console.ReadLine(),"d/M/yyyy",CultureInfo.InvariantCulture);
                long count = long.Parse(Console.ReadLine());

                decimal currentPrice = DateTime.DaysInMonth(date.Year, date.Month)*count*price;
                sum += currentPrice;

                Console.WriteLine($"The price for the coffee is: ${currentPrice:F2}");
            }
            Console.WriteLine($"Total: ${sum:F2}");
        }
    }
}

