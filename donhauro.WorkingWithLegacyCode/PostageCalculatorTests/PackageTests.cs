using System;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PostageCalculator;

namespace PostageCalculatorTests
{
    [TestClass]
    public class PackageTests
    {
        private Package TestTarget;

        [TestInitialize]
        public void TestInitialize()
        {
            TestTarget = new Package(800, 324, 229, 100);
        }

        [TestMethod]
        public void CalculateShouldReturn4000()
        {
            var result = TestTarget.PostageInBaseCurrency();
            result.Should().Be(4000);
        }
    }
}
