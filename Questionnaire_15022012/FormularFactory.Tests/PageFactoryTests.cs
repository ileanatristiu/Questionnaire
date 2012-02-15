using System.IO;
using Formular;
using Moq;
using NUnit.Framework;

namespace FormularFactory.Tests
{
    [TestFixture]
    public class PageFactoryTests
    {
        [Test]
        public void CreatePAge_WhenHAssections_WillSetTheItemsCollection()
        {
            var mock = new Mock<ISectionFactory>();
            var pageFactory = new PageFactory(mock.Object);

            Base item = pageFactory.Create(new StringReader(@"Page 1
Section 0"));

            Assert.AreEqual(1, item.Items.Count);
        }
    }
}