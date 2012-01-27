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
        public void CreatePage_Always_WillCreateAPage()
        {
            PageFactory pageFactory = new PageFactory();

            var page = pageFactory.CreatePage(new StringReader("Page1 0"));

            Assert.IsInstanceOf(typeof(IPage), page);
        }

        [Test]
        public void CreatePage_Always_WillCreateAPageWithSections()
        {
            Mock<ISectionaFactory> mock = new Mock<ISectionaFactory> { DefaultValue = DefaultValue.Mock };
            PageFactory pageFactory = new PageFactory { SectionFactory = mock.Object };

            var page = pageFactory.CreatePage(new StringReader(@"Page1 1
Sec1 0"));

            mock.Verify(m => m.CreateSection(It.IsAny<StringReader>()), Times.Once());
            Assert.AreEqual(1, page.Sections.Count);
        }
    }
}
