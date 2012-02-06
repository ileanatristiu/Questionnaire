using System.IO;
using Formular;
using FormularFactory;
using NUnit.Framework;

namespace ForumularFactory.Test
{
    [TestFixture]
    public class QuestionFactoryTests
    {
        [Test]
        public void CreateQuestion_WhenFT_WillCreateAFreeTextQuestion()
        {
            QuestionFactory questionFactory = new QuestionFactory();

            var question = questionFactory.CreateQuestion(new StringReader("Q1 FT Name"));

            Assert.IsInstanceOf(typeof(FreeTextQuestion), question);
        }
    }
}
