using Formular;
using NUnit.Framework;

namespace FormularFactory
{
    [TestFixture]
    public class FreeTextQuestionTests
    {
        [Test]
        public void ToString_WillreturnTheCorrectFormat()
        {
            var freeTextQuestion = new FreeTextQuestion();

            var s = freeTextQuestion.ToString();

            Assert.AreEqual("   ___", s);
        }
    }
}