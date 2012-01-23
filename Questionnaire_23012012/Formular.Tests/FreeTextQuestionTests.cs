using NUnit.Framework;

namespace Formular.Tests
{
    [TestFixture]
    public class FreeTextQuestionTests
    {
        [Test]
        public void ToString_WillReturnTheCorrectString()
        {
            FreeTextQuestion freeTextQuestion = new FreeTextQuestion { Text = "Question" };

            var s = freeTextQuestion.ToString();

            Assert.AreEqual("   ___", s);
        }
    }
}
