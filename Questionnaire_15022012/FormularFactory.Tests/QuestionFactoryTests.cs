using System.IO;
using Formular;
using NUnit.Framework;

namespace FormularFactory.Tests
{
    [TestFixture]
    public class QuestionFactoryTests
    {
        [Test]
        public void CreateQuestion_Always_WillReturnAFreeTextQuestion()
        {
            var questionFactory = new QuestionFactory();

            IQuestion question = questionFactory.CreateQuestion(new StringReader("Q1 Name"));

            Assert.IsInstanceOf(typeof(FreeTextQuestion), question);
        }
    }
}