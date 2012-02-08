using System.IO;
using Formular;
using NUnit.Framework;

namespace FormularFactory.Test
{
    [TestFixture]
    public class QuestionFactoryTests
    {
        [Test]
        public void CreateQuestion_WithFT_WillCreateAFreeTExtQuestion()
        {
            QuestionFactory questionFactory = new QuestionFactory();

            var question = questionFactory.CreateQuestion(new StringReader("Q1 Name"));

            Assert.IsInstanceOf(typeof(FreeTextQuestion), question);
            Assert.AreEqual("Name", question.Text);
        }
    }
}