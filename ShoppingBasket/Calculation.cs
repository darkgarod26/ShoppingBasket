using System;
using System.Collections.Generic;

namespace ShoppingBasket
{
    public class Calculation
    {
        public Result calculate(string[] insertedGroceries)
        {
            var respository = new Repository();
            var products = new List<Product>();
            var result = new Result();

            foreach (var productName in insertedGroceries)
            {
                var product = respository.GetProduct(productName);
                if (product != null)
                {
                    products.Add(product);
                }
                else
                {
                    result.ProductFail = productName;
                }
            }

            result.Discounts = new List<string>();

            foreach (var product in products)
            {
                var price = product.Price;

                if (product.Name == "Apples")
                {
                    price = product.Price - (product.Price * 0.10);
                    result.Discounts.Add("Apples 10% off: -€0.10");

                }

                if (product.Name == "Bread")
                {
                    var soupCount = 0;

                    foreach (var item in products)
                    {
                        if (item.Name == "Soup")
                        {
                            soupCount++;
                        }
                    }

                    if (soupCount > 1)
                    {
                        price = product.Price - (product.Price * 0.50);
                        result.Discounts.Add("Bread 50% off: -€0.40");
                    }
                }

                result.TotalPrice = result.TotalPrice + price;
                result.SubTotal = result.SubTotal + product.Price;
            }

            return result;
           
        }
    }
}
