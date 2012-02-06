using System.IO;
using Formular;
using FormularFactory;
using Moq;
using NUnit.Framework;

namespace ForumularFactory.Test
{
    [TestFixture]
    public class PageFactoryTests
    {
        private PageFactory _pageFactory;

        [SetUp]
        public void Setup()
        {
            Mock<ISectionFactory> mockSection = new Mock<ISectionFactory>();
            _pageFactory = new PageFactory { SectionFactory = mockSection.Object };
        }

        [Test]
        public void CreatePage_Always_WillCreateAPageWithName()
        {
            var page = _pageFactory.CreatePage(new StringReader("Page1 0"));

            Assert.IsInstanceOf(typeof(IPage), page);
            Assert.AreEqual("Page1", page.Name);
        }

        [Test]
        public void CreatePage_WhenHasSections_WillSetTheSectionsList()
        {
            var page = _pageFactory.CreatePage(new StringReader(@"Page1 1
Sec1 0"));

            Assert.AreEqual(1, page.Sections.Count);
        }

        [Test]
        public void CreatePage_Always_WillSetTheIndex()
        {
            var page = _pageFactory.CreatePage(new StringReader("Page1 0"), 3);

            Assert.AreEqual(3, page.Index);
        }
    }
}