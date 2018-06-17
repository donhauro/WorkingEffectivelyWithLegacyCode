using AdaptParameter.Common;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AdaptParameterTests
{
    [TestClass]
    public class ControlAccessServiceTests
    {
        private AdaptParameter.Version002.ControlAccessService TestTarget;

        [TestInitialize]
        public void TestInitialize()
        {
            var repository = new MemberRespoitory();
            var validator = new SecurityTokenValidator();
            TestTarget = new AdaptParameter.Version002.ControlAccessService(repository, validator);
        }

        [TestMethod]
        public void IsAuthorizedShouldBeTrue()
        {
            //Arrange
            var controlAccess = new FakeControlAccessReaderDevice();

            //Action
            //var result = TestTarget.IsAuthorized(fakeControlAccessService);

            //Assert
            //result.Should().BeTrue();
        }
    }
}
