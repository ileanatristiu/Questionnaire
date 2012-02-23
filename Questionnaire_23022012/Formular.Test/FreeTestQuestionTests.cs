using NUnit.Framework;

namespace Formular.Test
{
    [TestFixture]
    public class FreeTestQuestionTests
    {
        [Test]
        public void ToString_WillReturnTheCorrectString()
        {
            var freeTextQuestion = new FreeTextQuestion();

            var s = freeTextQuestion.ToString();

            Assert.AreEqual("   ___", s);
        }
    }
}