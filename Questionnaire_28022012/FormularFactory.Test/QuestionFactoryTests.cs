using System.IO;
using Formular;
using FormulatFactory;
using Moq;
using NUnit.Framework;

namespace FormularFactory.Test
{
    [TestFixture]
    public class QuestionFactoryTests
    {
        [Test]
        public void Create_WithFT_WillCreateAFreeTextQuestion()
        {
            var questionFactory = new QuestionFactory();

            var question = questionFactory.Create(new StringReader("Q1 FT Name"));

            Assert.IsInstanceOf(typeof(FreeTextQuestion), question);
        }

        [Test]
        public void Create_WithSC_WillCreateASingleChoiceQuestion()
        {
            var questionFactory = new QuestionFactory();

            Base question = questionFactory.Create(new StringReader("Q1 SC Sex 2 Female Male"));

            Assert.IsInstanceOf(typeof(SingleChoiceQuestion), question);
        }

        [Test]
        public void Create_WithSC_WillSetTheListOfPossibleAnswers()
        {
            var mockQuestion = new Mock<IQuestionFactory>();
            var questionFactory = new QuestionFactory { AnswersFactory = mockQuestion.Object };

            Base question = questionFactory.Create(new StringReader("Q1 SC Sex 2 Female Male"));

            Assert.AreEqual(2, question.Items.Count);
        }
    }
}