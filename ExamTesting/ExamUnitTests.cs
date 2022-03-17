using System;
using Xunit;
using ExamFunc;
using System.Collections.Generic;
using System.IO;


namespace ExamTesting
{
    public class ExamUnitTests
    {
        [Fact]
        public void TestIfFileReaderNotReturnEmptyString()
        {
            // Arrange
            var d = new FileReaderService();
            // Act
            var actualText = d.FileReader(@"C:\Users\Kornelijus\source\repos\ExamFunc\ExamFunc\Files\Drinks.CSV.txt");
            // Assert
            Assert.NotEmpty(actualText);
        }
        [Fact]
        public void CheckIfValidationReturnsNullOnFalseVacancyTable()
        {
            // Arrange
            var newTable = new Table("1", 2, false);
            // Act
            var result = newTable.TableVacancyValidation();
            // Assert
            Assert.Null(result);
        }
        [Fact]
        public void CheckIfValidationDoesNotReturnNullOnTrueVacancyTable()
        {
            // Arrange
            var newTable = new Table("1", 2, true);
            // Act
            var result = newTable.TableVacancyValidation();
            // Assert
            Assert.NotNull(result);
        }
        [Fact]
        public void CheckIfChangeTableVacancyChangesFromFalseToTrue()
        {
            // Arrange
            var newTable = new Table("1", 2, false);
            // Act
            newTable.ChangeTableVacancy();
            // Assert
            Assert.True(newTable.IsVacant);
        }
        [Fact]
        public void CheckIfIntValidatioParsesStringToInt()
        {
            // Arrange
            string input = "8";
            // Act
            int d = input.IntValidation();
            // Assert
            Assert.Equal(8, d);
        }
        [Fact]
        public void CheckIfCalculateOrderSumCalcutesAllObjectsInList()
        {
            // Arrange
            var order = new Order();
            order.GoodsList = new List<Goods>() { new Goods("Coke", 1.00M), new Goods("Salami", 2.35M) };
            var expected = 3.35M;
            //Act
            var actual = order.CalculateOrderSum();
            // Assert
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void CheckIfRemoveItemMethodRemovesItemFromList()
        {
            //Arrange
            var order = new Order();
            order.GoodsList = new List<Goods>() { new Goods("Coke", 1.00M), new Goods("Salami", 2.35M) };
            Console.SetIn(new StringReader("1"));
            // Act
            RemoveItemMenu.RemoveItem(order);
            // Assert
            Assert.DoesNotContain("Salami",order.ToString());
        }
        [Fact]
        public void CheckifAfterUsingPickFromListMethodOrderObjectCalculatesSumCorrectly()
        {
            /////Contains the item in list but not sure why it shows failure
            //Arrange
            var order = new Order();
            order.GoodsList = new List<Goods>() { new Goods("Coke", 1.00M), new Goods("Salami", 2.35M) };
            var DrinkList = new List<Drinks>() {new Drinks("Champagne", 3.00M), new Drinks("OatMeal", 1.00M)};
            var expected = 6.35M;
            Console.SetIn(new StringReader("0"));
            //Act
            GoodsMenu.PickFromList(DrinkList, order);
            var result = order.CalculateOrderSum();
            //Assert
            Assert.Equal(expected,result);
        }
        [Fact]
        public void CheckIfToStringMethodContainsCalculateOrderWhenUsedOnOrderObject()
        {
            //Arrange
            var order = new Order();
            order.GoodsList = new List<Goods>() { new Goods("Coke", 1.00M), new Goods("Salami", 2.35M) };
            var drinkList = new List<Drinks>() { new Drinks("Champagne", 3.00M), new Drinks("OatMeal", 1.00M) };
            var expected = order.CalculateOrderSum();
            Console.SetIn(new StringReader("0"));
            //Act    
            var result = order.ToString();
            //Assert
            Assert.Contains(Convert.ToString(expected),result);
        }
        [Fact]
        public void CheckIfDrinksGetListDoesNotReturnEmpty()
        {
            //Arrange
            var drinks = new DrinksRepo();
            //Act
            drinks.GetList();
            //Assert
            Assert.NotEmpty(drinks.DrinkList);

        }
    }
}
