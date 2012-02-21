using NUnit.Framework;

namespace Formular.Test
{
    [TestFixture]
    public class QuestionTests
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