using donhauro.WorkingWithLegacyCode.Console;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// ReSharper disable All

namespace ConsoleTests
{
    [TestClass]
    public class SaleTests
    {
        [TestMethod]
        public void ScanShouldCallShowLineCorrectly()
        {
            //Arrange
            Sale TestTarget = new Sale();

            //Act
            TestTarget.Scan("Milch 0,89 €");

            //Assert
            //????
        }
    }
}
