using System;

namespace ShoppingBasket
{
    class Program
    {
        static void Main()
        {
            Console.Write("Insert desired Groceries:  ");
            var insertedGroceries = Console.ReadLine().Split(' ', ',');
            var calculation = new Calculation();
            var result = calculation.calculate(insertedGroceries);

            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Shopping Cost");

            if (result.ProductFail == null)
            {
                Console.WriteLine("Subtotal: €" + result.SubTotal);

                foreach (var discount in result.Discounts)
                {
                   Console.WriteLine(discount);
                }

                if (result.Discounts.Count == 0)
                {
                    Console.WriteLine("(No offers available)");
                }

                Console.WriteLine("Total price: €" + result.TotalPrice);
            }
            else
            {
                Console.WriteLine("Whoops! something went wrong, can't find item with the name " + result.ProductFail);
            }
        }
    }
}
