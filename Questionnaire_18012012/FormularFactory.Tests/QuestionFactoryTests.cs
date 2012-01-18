using Formular;
using NUnit.Framework;

namespace FormularFactory.Tests
{
    [TestFixture]
    class QuestionFactoryTests
    {
        [Test]
        public void CreateQuestion_WWithFT_WillCreateAFreeTextQuestion()
        {
            QuestionFactory questionFactory = new QuestionFactory();

            var question = questionFactory.CreateQuestion("Q1 FT Numele");

            Assert.IsInstanceOf(typeof(FreeTextQuestion), question);
            Assert.That("Numele", Is.EqualTo(question.Text));
        }
    }
}
