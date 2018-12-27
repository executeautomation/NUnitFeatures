using NUnit.Framework;

namespace NUnitFeatures
{
    /// <summary>
    /// Class to demonstrate NUnits features
    /// </summary>
    public class NUnitFeaturesDemo
    {

        /// <summary>
        /// Test method with TestCase attribute
        /// </summary>
        /// <param name="val1"></param>
        /// <param name="val2"></param>
        /// <param name="result"></param>
        [Test]
        [TestCase(20,30, 50)]
        [TestCase(60, 70, 130)]
        public void TestAdditionOps(int val1, int val2, int result)
        {
            Assert.That(val1 + val2, Is.EqualTo(result), "The result is not the one which is expected");
        }

        /// <summary>
        /// Test method with TestCaseSource attribute to read data from TestDataSource class
        /// </summary>
        /// <param name="val1"></param>
        /// <param name="val2"></param>
        /// <param name="result"></param>
        [Test]
        [TestCaseSource(typeof(TestDataSource), "Datas")]
        public void TestAddOpsWithExtData(int val1, int val2, int result)
        {
            Assert.That(val1 + val2, Is.EqualTo(result), "The result is not the one which is expected");
        }

        /// <summary>
        /// Test method with TestCaseSource attribute to read data from TestDataSource class and with expected result
        /// </summary>
        /// <param name="val1"></param>
        /// <param name="val2"></param>
        /// <param name="result"></param>
        [Test]
        [TestCaseSource(typeof(TestDataSource), "Datas")]
        public int TestAddOps_With_ExtData_And_ExpectedResult(int val1, int val2)
        {
            return val1 + val2;
        }

        /// <summary>
        /// Test method with TestCase attribute and Expected result named parameter
        /// </summary>
        /// <param name="val1"></param>
        /// <param name="val2"></param>
        /// <param name="result"></param>
        [Test]
        [TestCase(20, 30, ExpectedResult = 50)]
        [TestCase(60, 70, ExpectedResult = 130)]
        public int TestAdditionOpsWithExpectedResult(int val1, int val2)
        {
            return val1 + val2;
        }



        [Test]
        [Sequential]
        public void TestWithTestData_Values([Values(10,20)]int val1,[Values(30,40)]int val2)
        {
            var result = val1 + val2;
        }






        /// <summary>
        /// Usual Test method of NUnit
        /// </summary>
        [Test]
        public void TestAddOperation()
        {
            int val1 = 20;
            int val2 = 30;
            int actualResult = val1 + val2;
            Assert.That(actualResult, Is.EqualTo(50), "Result is not expected");
        }

        [Test]
        public void TestAnotherAddOperation()
        {
            int val1 = 60;
            int val2 = 70;
            int actualResult = val1 + val2;
            Assert.That(actualResult, Is.EqualTo(130), "Result is not expected");
        }
    }
}
