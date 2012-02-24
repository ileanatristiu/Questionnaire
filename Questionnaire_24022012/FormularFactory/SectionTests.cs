using Formular;
using NUnit.Framework;

namespace FormularFactory
{
    [TestFixture]
    public class SectionTests
    {
        [Test]
        public void ToString_WillReturnTheCorrectFormatForSections()
        {
            var section = new Section { Name = "Sec" };
            section.Items.Add(new FreeTextQuestion());

            var s = section.ToString();

            Assert.IsTrue(s.Contains("  Sec"));
            Assert.IsTrue(s.Contains("   ___"));
        }
    }
}