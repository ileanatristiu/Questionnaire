using System.IO;
using Formular;
using NUnit.Framework;

namespace FormularFactory.Test
{
    [TestFixture]
    public class QuestionFactoryTests
    {
        [Test]
        public void CreateQuestion_Always_WillCreateAFreeTextQuestion()
        {
            var questionFactory = new QuestionFactory();

            Base question = questionFactory.Create(new StringReader("Q1 Name"));

            Assert.IsInstanceOf(typeof(FreeTextQuestion), question);
        }
    }
}