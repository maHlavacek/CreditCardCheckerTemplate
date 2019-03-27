using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CreditCardChecker.Test
{
    [TestClass]
    public class CreditCardCheckerTest
    {
        [DataTestMethod]
        [DataRow("2718281828458567")]
        [DataRow("0000111100001119")]
        [DataRow("1234123412341238")]
        [DataRow("1966000427030002")]
        public void CreditCardChecker_ValidCreditCard_ShouldBeValid(string creditCardNumber)
        {
            // Arrange
            // do nothing

            // Act
            bool isValid = CreditCardChecker.IsCreditCardValid(creditCardNumber);

            // Assert
            Assert.IsTrue(isValid, $"{creditCardNumber} is valid!");

        }

        [DataTestMethod]
        [DataRow("2718211828458567")]
        [DataRow("Hurra die Gams!!")]
        [DataRow("")]
        [DataRow("9876543210123456")]
        [DataRow("00000000000000000")]
        [DataRow("1000000000000002")]
        public void CreditCardChecker_InvalidCreditCard_ShouldBeInvalid(string creditCardNumber)
        {
            // Arrange
            // do nothing

            // Act
            bool isValid = CreditCardChecker.IsCreditCardValid(creditCardNumber);

            // Assert
            Assert.IsFalse(isValid, $"{creditCardNumber} is not valid!");

        }

    }
}
