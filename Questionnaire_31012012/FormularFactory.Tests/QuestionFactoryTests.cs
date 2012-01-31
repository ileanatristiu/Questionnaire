using System.IO;
using Formular;
using NUnit.Framework;

namespace FormularFactory.Tests
{
    [TestFixture]
    public class QuestionFactoryTests
    {
        [Test]
        public void CreateQuestion_WillCreateAFreeTextQuestion()
        {
            QuestionFactory questionFactory = new QuestionFactory();

            var question = questionFactory.CreateQuestion(new StringReader("Q1 Name"));

            Assert.IsInstanceOf(typeof(FreeTextQuestion), question);
        }
    }
}
