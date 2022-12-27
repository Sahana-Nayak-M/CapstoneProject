using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Test
{
    class CalculatorProgramTest
    {
        [Test]
        public void Add_Test()
        {
            /// AAA concept 
            //1. Arrange
            Program calc = new Program();
            int num1 = 2;
            int num2 = 3;
            int expectedResult = 5;
            int actualResult;

            // 2. Act
            actualResult = calc.Add(num1, num2);

            // 3. Assert
            Assert.That(expectedResult, Is.EqualTo(actualResult));

        }


        [Test]
        public void Div_Test()
        {
            /// AAA concept 
            //1. Arrange
            Program calc = new Program();
            int num1 = 2;
            int num2 = 0;


            // 2. Act &&& Assert
            Assert.That(()=> calc.Div(num1, num2), Throws.Exception.TypeOf<DivideByZeroException>());

            // 3. Assert
            //Assert.That(expectedResult, Is.EqualTo(actualResult));

        }


        [Test]
        public void Sub_Test()
        {
            /// AAA concept 
            //1. Arrange
            Program calc = new Program();
            int num1 = 5;
            int num2 = 3;
            int expectedResult = 2;
            int actualResult;

            // 2. Act
            actualResult = calc.Sub(num1, num2);

            // 3. Assert
            Assert.AreEqual(expectedResult, actualResult);

        }
        [Test]
        public void Mul_Test()
        {
            /// AAA concept 
            //1. Arrange
            Program calc = new Program();
            int num1 = 2;
            int num2 = 3;
            int expectedResult = 6;
            int actualResult;

            // 2. Act
            actualResult = calc.Mul(num1, num2);

            // 3. Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

      

    }
}
