using System.IO;
using Formular;
using Moq;
using NUnit.Framework;

namespace FormularFactory.Test
{
    [TestFixture]
    public class PageFactoryTests
    {
        private PageFactory _pageFactory;

        [SetUp]
        public void SetUp()
        {
            Mock<ISectionFactory> mockSectionFactory = new Mock<ISectionFactory>();
            _pageFactory = new PageFactory { SectionFactory = mockSectionFactory.Object };
        }

        [Test]
        public void CreatePage_WillReturnAPageWithName()
        {
            var page = _pageFactory.CreatePage(new StringReader("Page1 0"));

            Assert.IsInstanceOf(typeof(IPage), page);
            Assert.AreEqual("Page1", page.Name);
        }

        [Test]
        public void CreatePage_WillCreateAPageWithSections()
        {
            var page = _pageFactory.CreatePage(new StringReader(@"Page1 1
Sec1 0"));

            Assert.AreEqual(1, page.Sections.Count);
        }

        [Test]
        public void CreatePage_WillSetTheProperIndex()
        {
            var page = _pageFactory.CreatePage(new StringReader("Page1 0"), 1);

            Assert.AreEqual(1, page.Index);
        }
    }
}
