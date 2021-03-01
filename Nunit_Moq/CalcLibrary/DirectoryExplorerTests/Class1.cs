using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Moq;
using MagicFilesLib;

namespace DirectoryExplorerTests
{
    [TestFixture]
    public class Class1
    {
        private IDirectoryExplorer mockDictionaryExplorer;
        private readonly string _file1 = "file.txt";
        private readonly string _file2 = "file2.txt";

        [OneTimeSetUp]
        public void Init()
        {
            mockDictionaryExplorer = Mock.Of<IDirectoryExplorer>();
            Mock.Get(mockDictionaryExplorer)
                .Setup(d => d.GetFiles(It.IsAny<string>()))
                .Returns(new List<string>{
                         _file1,
                         _file2
                });
        }

        [Test]
        public void DirectoryExplorerTest()
        {
            var expected = mockDictionaryExplorer.GetFiles(@"c:\");

            Assert.NotNull(expected);
            Assert.IsTrue(expected.Count == 2);
            Assert.IsTrue(expected.Contains(_file1));
        }
    }
}