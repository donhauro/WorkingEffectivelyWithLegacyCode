using System.Collections.Generic;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SproutOutMethod.Version2;

namespace SproutOutMethodeTest
{
    [TestClass]
    public class FileUpdateManagerTests
    {
        private FileUpdateManager TestTarget;

        [TestInitialize]
        public void Initialize()
        {
            TestTarget = new FileUpdateManager();
        }

        [TestMethod]
        public void GetUniqueFileListShouldReturnUniqueList()
        {
            PrivateObject privateObject =  new PrivateObject(typeof(FileUpdateManager));

            var result = privateObject.Invoke("GetUniqueFileList", new List<string> {"a", "b", "c", "a"});

            result.Should().BeOfType<List<string>>().Which.Count.Should().Be(3);

        }
    }
}
