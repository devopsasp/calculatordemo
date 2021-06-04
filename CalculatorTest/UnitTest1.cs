using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace CalculatorTest
{
   
    [TestClass]
    public class UnitTest1
    {
        CalculatorApp.Calculator obj = new CalculatorApp.Calculator();
   
        [TestMethod]
        public void TestMethod1()
        {
            int actual = obj.add(12, 10);
            int expected = 22;
            Assert.AreEqual(expected,actual);
        }
    }
}
