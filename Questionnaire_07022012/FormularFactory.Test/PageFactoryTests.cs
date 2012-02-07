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
        public void CreatePage_Always_WillCreateAPageWithNAmeAndIndex()
        {
            PageFactory pageFactory = new PageFactory();

            var page = pageFactory.CreatePage(new StringReader("Page1 0"), 1);

            Assert.IsInstanceOf(typeof(IPage), page);
            Assert.AreEqual("Page1", page.Name);
            Assert.AreEqual(1, page.Index);
        }

        [Test]
        public void CreatePage_WhenHasSections_WillSetTheSectionsList()
        {
            Mock<ISectionFactory> mockSectionFactory = new Mock<ISectionFactory>();
            PageFactory pageFactory = new PageFactory { SectionFactory = mockSectionFactory.Object };

            var page = pageFactory.CreatePage(new StringReader(@"Page1 2
Sec1 0
Sec2 0"), 1);

            Assert.AreEqual(2, page.Sections.Count);
        }
    }
}