using NUnit.Framework;

namespace Formular.Tests
{
    [TestFixture]
    public class FreeTextQuestionTests
    {
        [Test]
        public void ToString_WillReturnTheCorrectFormat()
        {
            IQuestion freeTextQuestion = new FreeTextQuestion();

            var s = freeTextQuestion.ToString();

            Assert.AreEqual("   ___", s);
        }
    }
}
