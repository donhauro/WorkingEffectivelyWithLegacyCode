﻿using donhauro.WorkingWithLegacyCode.Console001;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ConsoleTests
{
    [TestClass]
    public class SaleTests001
    {
        private const string MilchBarcode = "Milch 0,89 €";

        [TestMethod]
        public void ScanShouldCallShowLineCorrectly()
        {
            //Arrange
            var fakeDisplay = new FakeDisplay();
            var testTarget = new Sale(fakeDisplay);

            //Act
            testTarget.Scan(MilchBarcode);

            //Assert
            Assert.AreEqual(fakeDisplay.LastScan(), MilchBarcode);
        }
    }

    public class FakeDisplay: IDisplay
    {
        private string LastBarcode;

        //Sensing
        public string LastScan()
        {
            return LastBarcode;
        }

        public void ShowLine(string barcode)
        {
            LastBarcode = barcode;
        }
    }
}
