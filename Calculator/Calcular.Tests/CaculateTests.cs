using Calculator;
using NUnit.Framework;
using System;

namespace Calcular.Tests
{
    [TestFixture]
    public class CaculateTests
    {
        [Test]
        public void CalculateSum(
            [Values(-10, 0, 7)] int x,
            [Values(-5, 0, 4)] int y)
        {
            //Arrange

            //Act
            int output = Calculate.Sum(x, y);
            //Assert
            Assert.AreEqual(x + y, output);
        }

        [Test]
        public void CalculateSub(
            [Values(-10, 0, 7)] int x,
            [Values(-5, 0, 4)] int y)
        {
            //Arrange

            //Act
            int output = Calculate.Sub(x, y);
            //Assert
            Assert.AreEqual(x - y, output);
        }

        [Test]
        public void CalculateDiv(
            [Values(0, -20, 18)] int x,
            [Values(-14, 4)] int y)
        {
            //Arrange

            //Act
            int output = Calculate.Div(x, y);
            //Assert
            Assert.AreEqual(x / y, output);
        }
        [Test]
        public void CalculateDivCannotDivideZero(
            [Values(0, -20, 18)] int x,
            [Values(0, 0)] int y)
        {
            //Arrange

            //Act

            //Assert
            Assert.Throws<DivideByZeroException>(() => CalculateDiv(x, y));
        }

        [Test]
        public void CalculateMult(
            [Values(-10, 0, 7)] int x,
            [Values(-5, 0, 4)] int y)
        {
            //Arrange

            //Act
            int output = Calculate.Mult(x, y);
            //Assert
            Assert.AreEqual(x * y, output);
        }
    }
}
