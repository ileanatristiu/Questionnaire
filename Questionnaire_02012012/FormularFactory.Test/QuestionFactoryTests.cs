using System.IO;
using NUnit.Framework;
using Formular;

namespace FormularFactory.Test
{
    [TestFixture]
    public class QuestionFactoryTests
    {
        [Test]
        public void CreateQuestion_WillReturnAFreeTextQuestion()
        {
            QuestionFactory questionFactory = new QuestionFactory();

            var question = questionFactory.CreateQuestion(new StringReader("Q1 Name"));

            Assert.IsInstanceOf(typeof(FreeTextQuestion), question);
        }
    }
}
