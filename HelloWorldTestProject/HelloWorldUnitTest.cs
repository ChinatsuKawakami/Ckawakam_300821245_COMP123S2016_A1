using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HelloWorldTestProject
{
    [TestClass]
    public class HelloWorldUnitTest
    {
        [TestMethod]
        public void HelloWorldToConsoleTestMethod()
        {
            //Arrange
            string expectedresult = "Hello,World!";

            //Act
            string result = Ckawakam_300821245_COMP123S2016_A1.Program.HelloWorldToConsole();

            //Assert
            Assert.AreEqual(expectedresult, result);
        }
    }
}
