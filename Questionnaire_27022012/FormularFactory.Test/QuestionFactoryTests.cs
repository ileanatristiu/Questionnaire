using System.IO;
using Formular;
using Moq;
using NUnit.Framework;

namespace FormularFactory.Test
{
    [TestFixture]
    public class QuestionFactoryTests
    {
        [Test]
        public void Create_WithFT_WillReturnAFreeTextQuestion()
        {
            var questionFactory = new QuestionFactory();

            Base question = questionFactory.Create(new StringReader("Q1 FT Name"));

            Assert.IsInstanceOf(typeof(FreeTextQuestion), question);
        }

        [Test]
        public void Create_WithSC_WillReturnASingleChoiceQuestion()
        {
            var mockSingleChoiceQFactory = new Mock<IChoiceQuestionFactory>();
            var questionFactory = new QuestionFactory { SingleChoiceQuestion = mockSingleChoiceQFactory.Object };

            Base question = questionFactory.Create(new StringReader("Q1 SC Sex 2 Female Male"));

            Assert.IsInstanceOf(typeof(SingleChoiceQuestion), question);
            Assert.AreEqual(2, question.Items.Count);
        }
    }
}