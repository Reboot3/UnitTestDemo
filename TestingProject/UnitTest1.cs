using CalculationProject;

namespace TestingProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            float number1 = 5;
            float number2 = 6;
            float expected = 11;
            float actual = number1 + number2;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestMethod2()
        {
            float number1 = 10;
            float number2 = 6;
            float expected = 4;
            float actual = number1 - number2;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestAddition()
        {
            CalculationManagement cm = new CalculationManagement();
            float number1 = 10;
            float number2 = 6;
            float expected = 16;
            float actual = cm.Addition(number1, number2);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestDivision()
        {
            CalculationManagement cm = new CalculationManagement();
            float number1 = 12;
            float number2 = 2;
            float expected = 6;
            float actual = cm.Division(number1, number2);
            Assert.AreEqual(expected, actual);
        }

    }

}