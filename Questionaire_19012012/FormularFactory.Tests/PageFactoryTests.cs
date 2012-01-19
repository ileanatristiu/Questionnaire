using System.IO;
using NUnit.Framework;

namespace FormularFactory.Tests
{
    [TestFixture]
    public class PageFactoryTests
    {
        [Test]
        public void CreatePage_Always_WillCreateAPageWithName()
        {
            PageFactory pageFactory = new PageFactory();

            pageFactory.CreatePage(new StringReader(@"Page 1"));
        }
    }
}
