using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingBasket
{
    public class Result
    {
        public double TotalPrice {get; set;}

        public double SubTotal { get; set; }

        public string ProductFail { get; set; }

        public List<string> Discounts { get; set; }
    }
}
