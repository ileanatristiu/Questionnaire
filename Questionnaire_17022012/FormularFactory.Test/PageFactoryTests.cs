using System.IO;
using Formular;
using NUnit.Framework;

namespace FormularFactory.Test
{
    [TestFixture]
    public class PageFactoryTests
    {
        [Test]
        public void CreatePage_Always_WillCreateAPageWithName()
        {
            var pageFactory = new PageFactory(new SectionFactory());

            Base page = pageFactory.Create(new StringReader("Page 0"));

            Assert.IsInstanceOf(typeof(Page), page);
            Assert.AreEqual("Page", page.Name);
        }

        [Test]
        public void CreatePage_WhenHasSections_WillSetTheListOfItems()
        {
            var pageFactory = new PageFactory(new SectionFactory());

            Base page = pageFactory.Create(new StringReader(@"Page 2
Sec1 0
Sec2 0"));

            Assert.AreEqual(2, page.Items.Count);
        }
    }
}