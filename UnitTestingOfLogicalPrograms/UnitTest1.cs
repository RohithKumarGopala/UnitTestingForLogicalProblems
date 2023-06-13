using System.Security.Cryptography.X509Certificates;
using UnitTestingOf_LogicalProgram;

namespace UnitTestingOfLogicalPrograms
{
    [TestClass]
    public class UnitTest1
    {
        LogicalPrograms logicalPrograms;

        [TestInitialize]
        public void Setup() { logicalPrograms = new LogicalPrograms(); }

        [TestMethod]
        [DataRow(8, 13)]
        [DataRow(5, 3)]
        [DataRow(3, 1)]
        [DataRow(7, 8)]
        public void Fibonacci_ForGivenNumber_ReturnsLastFibonacciNumber(int number, int expected)
        {
            int result = logicalPrograms.FibonacciSeries(number);
            Assert.AreEqual(expected, result);
        }

            [TestMethod]
        [DataRow(7, false)]
        [DataRow(28, true)]
        [DataRow(29, false)]
        [DataRow(30, false)]
        public void PerfectNumber_ForGivenNumber_ReturnIfPerfectNumberIsTrueOrFalse(int number, bool expected)
            {
                bool result = logicalPrograms.PerfectNumber(number);
                Assert.AreEqual(expected, result);
            }

            [TestMethod]
            [DataRow(13, true)]
            [DataRow(28, false)]
            [DataRow(41, true)]
            [DataRow(28, false)]
           public void PrimeNumber_ForGivenNumber_ReturnIfPrimeNumberIsTrueOrFalse(int number, bool expected)
            {
                bool result = logicalPrograms.PrimeNumber(number);
                Assert.AreEqual(expected, result);
            }

            [TestMethod]
            [DataRow(34, 43)]
            [DataRow(281, 182)]
            [DataRow(61, 16)]
            [DataRow(4329, 9234)]
             public void ReverseNumber_ForGivenNumber_ReturnTheReverseNumber(int number, int expected)
            {
                int result = logicalPrograms.ReverseNumber(number);
                Assert.AreEqual(expected, result);
            }
    }
 }
