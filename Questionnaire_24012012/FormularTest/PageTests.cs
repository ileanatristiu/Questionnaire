using System.Collections.Generic;
using Formular;
using NUnit.Framework;

namespace FormularTest
{
    [TestFixture]
    public class PageTests
    {
        [Test]
        public void ToString_WillReturnTheCorrectString()
        {
            Page page = new Page { Name = "Page1" };

            var s = page.ToString();

            Assert.AreEqual(" Page1", s);
        }

        [Test]
        public void ToString_WhenPageHasSections_WillReturnThePageWithTheSections()
        {
            List<ISection> sections = new List<ISection> { new Section { Name = "Sec1" }, new Section { Name = "Sec2" } };
            Page page = new Page { Name = "Page1", Sections = sections };

            var s = page.ToString();

            Assert.That(s, Contains.Substring(@"  Sec1
  Sec2"));
        }
    }
}
