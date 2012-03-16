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
        public void Create_WhenFT_WillReturnAFreeTextQuestion()
        {
            var questionFactory = new QuestionFactory();

            Base question = questionFactory.Create(new StringReader("FT Name"));

            Assert.IsInstanceOf(typeof(FreeTextQuestion), question);
        }

        [Test]
        public void Create_WhenSC_WillCallCreateChoiceQuestion()
        {
            var mockSingleChoiceQuestionFactory = new Mock<IChoiceQuestionFactory>();
            var questionFactory = new QuestionFactory { SingleChoiceQuestionFactory = mockSingleChoiceQuestionFactory.Object };

            Base question = questionFactory.Create(new StringReader("SC Sex 2 Female Male"));

            mockSingleChoiceQuestionFactory.Verify(m => m.CreateChoiceQuestion(It.IsAny<string>()), Times.Once());
        }
        [Test]
        public void Create_WhenMC_WillCallCreateChoiceQuestion()
        {
            var mockMultipleChoiceQuestionFactory = new Mock<IChoiceQuestionFactory>();
            var questionFactory = new QuestionFactory { MultipleChoiceQuestionFactory = mockMultipleChoiceQuestionFactory.Object };

            Base question = questionFactory.Create(new StringReader("MC Optiuni 3 op1 op2 op3"));

            mockMultipleChoiceQuestionFactory.Verify(m => m.CreateChoiceQuestion(It.IsAny<string>()), Times.Once());
        }
    }
}