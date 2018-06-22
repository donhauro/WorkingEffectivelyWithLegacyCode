using AdaptParameter.Common;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace AdaptParameterTests
{
    [TestClass]
    public class ControlAccessServiceTests
    {
        private AdaptParameter.Version001.ControlAccessService TestTarget;

        [TestInitialize]
        public void TestInitialize()
        {
            var repository = new MemberRespoitory();
            var validator = new SecurityTokenValidator();
            TestTarget = new AdaptParameter
                .Version001.ControlAccessService(repository, validator);
        }

        [TestMethod]
        public void IsAuthorizedShouldBeTrue()
        {
            //Arrange
            Mock<IControlAccessReaderDevice> mockedDevice = 
                new Mock<IControlAccessReaderDevice>();

            mockedDevice.Setup(x => x.GetHardwareToken()).Returns(string.Empty);
            mockedDevice.Setup(x => x.GetMemberId()).Returns(string.Empty);
            
            //Action
            var result = TestTarget.IsAuthorized(mockedDevice.Object);

            //Assert
            result.Should().BeTrue();

        }
    }
}
