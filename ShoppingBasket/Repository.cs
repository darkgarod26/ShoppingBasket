namespace ShoppingBasket
{
    class Repository
    {
        public Product GetProduct(string name)
        {
            var productName = name.ToLower();
            switch (productName)
            {
                case "bread":
                    return new Product("Bread", 0.80);

                case "soup":
                    return new Product("Soup", 0.65);

                case "milk":
                    return new Product("Milk", 1.30);

                case "apples":
                    return new Product("Apples", 1);

                default:
                    return null;
            }
        }
    }
}
