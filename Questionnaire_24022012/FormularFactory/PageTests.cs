using Formular;
using NUnit.Framework;

namespace FormularFactory
{
    [TestFixture]
    public class PageTests
    {
        [Test]
        public void ToString_WillreturnTheCorrectFormat()
        {
            var page = new Page { Name = "Page" };
            page.Items.Add(new Section { Name = "Sec" });

            var s = page.ToString();

            Assert.IsTrue(s.Contains(" Page"));
            Assert.IsTrue(s.Contains("  Sec"));
        }
    }
}