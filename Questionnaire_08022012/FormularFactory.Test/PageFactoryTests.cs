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
        public void CreatePage_Always_WillCreateAPAgeWithName()
        {
            PageFactory pageFactory = new PageFactory();

            var page = pageFactory.CreatePage(new StringReader("Page 0"));

            Assert.IsInstanceOf(typeof(IPage), page);
            Assert.AreEqual("Page", page.Name);
        }

        [Test]
        public void CreatePage_WhenPageHasSections_WillSetTheListOfSections()
        {
            Mock<ISectionFactory> mockSectionFactory = new Mock<ISectionFactory>();
            PageFactory pageFactory = new PageFactory { SectionFactory = mockSectionFactory.Object };

            var page = pageFactory.CreatePage(new StringReader(@"Page 1
Sec1 0"));

            Assert.AreEqual(1, page.Sections.Count);
        }
    }
}