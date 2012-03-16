using NUnit.Framework;

namespace Formular.Test
{
    [TestFixture]
    public class FreeTextQuestionTests
    {
        [Test]
        public void ToString_WillReturnTheCorrectFormat()
        {
            var freeTextQuestion = new FreeTextQuestion();

            string s = freeTextQuestion.ToString();

            Assert.AreEqual("   ___", s);
        }
    }
}