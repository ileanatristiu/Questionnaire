using NUnit.Framework;

namespace Formular.Test
{
    [TestFixture]
    public class SectionTest
    {
        [Test]
        public void ToString_WillReturnTheCorrectString()
        {
            var section = new Section { Name = "Sec" };

            var s = section.ToString();

            Assert.IsTrue(s.Contains("  Sec"));
        }
    }
}