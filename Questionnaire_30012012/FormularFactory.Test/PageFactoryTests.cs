using System.IO;
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

            var page = pageFactory.CreatePage(new StringReader(@"Page1 0"));

            Assert.AreEqual("Page1", page.Name);
        }

        [Test]
        public void CreatePage_WillReturnAPageWithSections()
        {
            Mock<ISectionFactory> mock = new Mock<ISectionFactory>();
            PageFactory pageFactory = new PageFactory { SectionFactory = mock.Object };

            var page = pageFactory.CreatePage(new StringReader(@"Page1 1
Sec1 0"));

            Assert.AreEqual(1, page.Sections.Count);
        }
    }
}
