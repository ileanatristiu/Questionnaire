using System.Collections.Generic;
using Formular;
using NUnit.Framework;

namespace FormularTest
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
        public void ToString_WhenSectionHasQuestions_WillReturnTheSectionWithQuestions()
        {
            List<IQuestion> questions = new List<IQuestion> { new FreeTextQuestion(), new FreeTextQuestion() };
            Section section = new Section { Name = "Sec1", Questions = questions };

            var s = section.ToString();

            Assert.That(s, Contains.Substring(@"  Sec1
   ___"));
        }
    }
}
