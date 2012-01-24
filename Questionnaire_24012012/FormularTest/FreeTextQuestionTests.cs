using Formular;
using NUnit.Framework;

namespace FormularTest
{
    [TestFixture]
    public class FreeTextQuestionTests
    {
        [Test]
        public void ToString_WillReturnTheCorrectFormat()
        {
            var freeTextQuestion = new FreeTextQuestion();

            var s = freeTextQuestion.ToString();

            Assert.AreEqual("   ___", s);
        }
    }
}
