using NUnit.Framework;

namespace Formular.Test
{
    [TestFixture]
    public class SectionTests
    {
        [Test]
        public void ToString_WillReturnTheCorrectFormat()
        {
            var section = new Section { Name = "Sec", Items = new ItemsCollection { new FreeTextQuestion() } };

            string s = section.ToString();

            Assert.AreEqual(@"  Sec
   ___", s);
        }
    }
}