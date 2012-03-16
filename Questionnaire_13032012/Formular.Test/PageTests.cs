using NUnit.Framework;

namespace Formular.Test
{
    [TestFixture]
    public class PageTests
    {
        [Test]
        public void ToString_WillReturnTheCorrectFormat()
        {
            var page = new Page {Name = "Page1"};

            string s = page.ToString();

            Assert.AreEqual("  Page1",s);
        }
    }
}