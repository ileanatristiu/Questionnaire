using System.Collections.Generic;
using NUnit.Framework;

namespace Formular.Tests
{
    [TestFixture]
    public class SectionTests
    {
        [Test]
        public void ToString_WillReturnTheCorrectFormat()
        {
            Section section = new Section { Name = "Sec1" };

            var s = section.ToString();

            Assert.AreEqual("  Sec1", s);
        }

        [Test]
        public void ToString_WillReturnTheCorrectFormatAndTheQuestions()
        {
            Section section = new Section { Name = "Sec1", Questions = new List<IQuestion> { new FreeTextQuestion(), new FreeTextQuestion() } };

            var s = section.ToString();

            Assert.That(s,Contains.Substring("   ___"));
            Assert.That(s,Contains.Substring("  Sec1"));
        }
    }
}
