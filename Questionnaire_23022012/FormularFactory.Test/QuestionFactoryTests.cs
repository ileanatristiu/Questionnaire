using System.IO;
using Formular;
using NUnit.Framework;

namespace FormularFactory.Test
{
    [TestFixture]
    public class QuestionFactoryTests
    {
        [Test]
        public void Create_Always_WillCreateAFreTextQuestion()
        {
            var questionFactory = new QuestionFactory();

            var question = questionFactory.Create(new StringReader("Q1 Name"));

            Assert.IsInstanceOf(typeof(FreeTextQuestion), question);
        }

        [Test]
        public void Create_WhenQuestionOfTypeFT_WillReturnFreeText()
        {
            var questionFactory = new QuestionFactory();

            var freeTextQuestion = questionFactory.Create(new StringReader("FT Numele"));

            Assert.That(freeTextQuestion.Name, Is.EqualTo("Numele"));
        }
    }
}