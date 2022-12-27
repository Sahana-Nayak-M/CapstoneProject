using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Calculator.Test
{
    class AssertTests
    {
        [Test]

        public void Test()
        {
            // Arrange
            int expectedResult = 200;
            int actualResult = 200;
            City city = new City();
            string actualCity;

            //Act

            actualCity = city.GetCity();


            // Assert
            Assert.That(expectedResult, Is.EqualTo(actualResult));
            Assert.That(expectedResult, Is.GreaterThanOrEqualTo(actualResult));
            Assert.That(actualCity, Is.Not.Null);

            //Assert.That(city.Contains("India"));
            Assert.That("Mumbai", Is.EqualTo(actualCity).IgnoreCase);


        }
    }
}
