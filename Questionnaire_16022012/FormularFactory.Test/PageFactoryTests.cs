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
            var pageFactory = new PageFactory();

            var page = pageFactory.Create(new StringReader("Page"));

            Assert.IsInstanceOf(typeof(Page), page);
            Assert.AreEqual("Page", page.Name);
        }

        [Test]
        public void CreatePage_WhenHasSections_WillSetTheListOfItems()
        {
            var pageFactory = new PageFactory();

            var page = pageFactory.Create(new StringReader(@"Page 1
Section"));

            Assert.AreEqual(1, page.Items.Count);
        }
    }
}