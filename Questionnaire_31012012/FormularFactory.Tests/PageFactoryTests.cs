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
        public void CreatePage_Always_WillCreateAPageWithSections()
        {
            Mock<ISectionFactory> mockSection = new Mock<ISectionFactory>();
            PageFactory pageFactory = new PageFactory { SectionFactory = mockSection.Object };

            var page = pageFactory.CreatePage(new StringReader(@"Page1 1
Sec1 "));

            Assert.IsInstanceOf(typeof(IPage), page);
            Assert.AreEqual("Page1", page.Name);
            Assert.AreEqual(1, page.Sections.Count);
        }
    }
}
