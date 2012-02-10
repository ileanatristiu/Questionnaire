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
        public void CreatePage_Always_WillCreateApageWithName()
        {
            PageFactory pageFactory = new PageFactory();

            var page = pageFactory.CreatePage(new StringReader("Page  0"));

            Assert.IsInstanceOf(typeof(Page), page);
            Assert.AreEqual("Page", page.Name);
        }

        [Test]
        public void CreatePage_WhenHasSections_WillSetTheListOfSections()
        {
            Mock<ISectionFactory> mockSection = new Mock<ISectionFactory>();
            PageFactory pageFactory = new PageFactory { SectionFactory = mockSection.Object };

            var page = pageFactory.CreatePage(new StringReader(@"Page 1
Section 0"));

            Assert.AreEqual(1, page.Sections.Count);
        }
    }
}