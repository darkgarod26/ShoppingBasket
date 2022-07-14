using Xunit;

namespace ShoppingBasket.Tests
{
    public class CalculationTests
    {
        [Fact]
        public void ShoppingBasket_PassValidProductsWithoutDiscount_ShoudReturnTotalAndSubTotalWithoutDiscounts()
        {
            //Arrange
            var calculation = new Calculation();
            string[] insertedGroceries = { "soup", "bread", "milk" };

            //Act
            var result = calculation.calculate(insertedGroceries);

            //Assert
            Assert.NotNull(result);
            Assert.Equal(2.75, result.SubTotal);
            Assert.Equal(2.75, result.TotalPrice);
            Assert.Empty(result.Discounts);
        }

        [Fact]
        public void ShoppingBasket_PassValidProductsWithDiscount_ShoudReturnTotalAndSubTotalWithDiscountsAndDiscountApplied()
        {
            //Arrange
            var calculation = new Calculation();
            string[] insertedGroceries = { "soup", "bread", "milk", "soup", "apples" };

            //Act
            var result = calculation.calculate(insertedGroceries);

            //Assert
            Assert.NotNull(result);
            Assert.Equal(4.40, result.SubTotal);
            Assert.Equal(3.90, result.TotalPrice);
            Assert.Equal(2, result.Discounts.Count);
        }

        [Fact]
        public void ShoppingBasket_PassInvalidProduct_ShoudReturInvalidProductMessage()
        {
            //Arrange
            var calculation = new Calculation();
            string[] insertedGroceries = { "carrots" };

            //Act
            var result = calculation.calculate(insertedGroceries);

            //Assert
            Assert.NotNull(result);
            Assert.Equal("carrots", result.ProductFail);
        }
    }
}
