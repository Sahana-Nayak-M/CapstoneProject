using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Calculator.Test
{
    class CalcTestData
    {
        public static List<TestCaseData> Get()
        {
            List<TestCaseData> cases = new List<TestCaseData>();
            var testcasedata = new TestCaseData(3, 2).Returns(5);
            var testcasedata2 = new TestCaseData(20, 10).Returns(30);
            cases.Add(testcasedata);
            cases.Add(testcasedata2);

            return cases;

        }

        public static List<TestCaseData> Get1()
        {
            List<TestCaseData> cases = new List<TestCaseData>();
            var testcasedata = new TestCaseData(3, 2).Returns(1);
            var testcasedata2 = new TestCaseData(20, 10).Returns(10);
            cases.Add(testcasedata);
            cases.Add(testcasedata2);

            return cases;

        }

        public static List<TestCaseData> Get2()
        {
            List<TestCaseData> cases = new List<TestCaseData>();
            var testcasedata = new TestCaseData(3, 2).Returns(6);
            var testcasedata2 = new TestCaseData(5, 2).Returns(10);
            cases.Add(testcasedata);
            cases.Add(testcasedata2);

            return cases;

        }

        public static List<TestCaseData> Get3()
        {
            List<TestCaseData> cases = new List<TestCaseData>();
            var testcasedata = new TestCaseData(10, 2).Returns(5);
            var testcasedata2 = new TestCaseData(20, 2).Returns(10);
            cases.Add(testcasedata);
            cases.Add(testcasedata2);

            return cases;

        }
    }
}
