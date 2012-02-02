using System.IO;
using Formular;
using Moq;
using NUnit.Framework;

namespace FormularFactory.Test
{
    [TestFixture]
    public class PageFactoryTests
    {
        [Test]
        public void CreatePage_WillReturnAPageWithName()
        {
            PageFactory pageFactory = new PageFactory();

            var page = pageFactory.CreatePage(new StringReader("Page1 0"));

            Assert.IsInstanceOf(typeof(IPage), page);
            Assert.AreEqual("Page1", page.Name);
        }

        [Test]
        public void CreatePage_WillCreateAPageWithSections()
        {
            Mock<ISectionFactory> mockSection = new Mock<ISectionFactory>();
            PageFactory pageFactory = new PageFactory { SectionFactory = mockSection.Object };

            var page = pageFactory.CreatePage(new StringReader(@"Page1 1
Sec1 0"));

            Assert.AreEqual(1, page.Sections.Count);
        }

        [Test]
        public void CreatePage_WilCreateAPageWithSectionThatAreInASpecificOrderByIndex()
        {
            Mock<ISectionFactory> mockSection = new Mock<ISectionFactory>();
            PageFactory pageFactory = new PageFactory { SectionFactory = mockSection.Object };

            var page = pageFactory.CreatePage(new StringReader(@"Page1 1
Sec1 0"));

            Assert.AreEqual(1, page.Sections[0].Index);
        }
    }
}
