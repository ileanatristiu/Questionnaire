using NUnit.Framework;

namespace Formular.Test
{
    [TestFixture]
    class FreeTextQuestionTests
    {
        [Test]
        public void ToString_WillReturnTheCorrectFormat()
        {
            FreeTextQuestion freeTextQuestion = new FreeTextQuestion();

            var s = freeTextQuestion.ToString();

            Assert.AreEqual("   ___", s);
        }
    }
}
