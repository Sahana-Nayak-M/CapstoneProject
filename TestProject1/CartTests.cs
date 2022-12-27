using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Calculator.Test
{
    class CalculatorTestWithDataset
    {
        static private List<TestCaseData>  TestData
        {
            get
            {
                return CalcTestData.Get();
            }
        }

        [Test]
        [TestCaseSource(nameof(TestData))]

        public int Add_Test(int num1, int  num2)
        {
            /// AAA concept 
            //1. Arrange
            Program calc = new Program();

            // 2. Act
            return calc.Add(num1, num2);

        }

        static private List<TestCaseData> TestData1
        {
            get
            {
                return CalcTestData.Get1();
            }
        }

        [Test]
        [TestCaseSource(nameof(TestData1))]

        public int Sub_Test(int num1, int num2)
        {
            /// AAA concept 
            //1. Arrange
            Program calc = new Program();

            // 2. Act
            return calc.Sub(num1, num2);

        }


        static private List<TestCaseData> TestData2
        {
            get
            {
                return CalcTestData.Get2();
            }
        }

        [Test]
        [TestCaseSource(nameof(TestData2))]

        public int Mul_Test(int num1, int num2)
        {
            /// AAA concept 
            //1. Arrange
            Program calc = new Program();

            // 2. Act
            return calc.Mul(num1, num2);

        }


        static private List<TestCaseData> TestData3
        {
            get
            {
                return CalcTestData.Get3();
            }
        }

        [Test]
        [TestCaseSource(nameof(TestData3))]

        public int Div_Test(int num1, int num2)
        {
            /// AAA concept 
            //1. Arrange
            Program calc = new Program();

            // 2. Act
            return calc.Div(num1, num2);

        }


    }
}
