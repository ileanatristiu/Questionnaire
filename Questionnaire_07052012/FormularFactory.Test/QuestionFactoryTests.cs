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
        public void Create_WithFT_WillCreateAFreeTextQuestion()
        {
            var questionFactory = new QuestionFactory();

            var question = questionFactory.Create(new StringReader("FT Name"));

            Assert.IsInstanceOf(typeof(FreeTextQuestion), question);
        }

        [Test]
        public void Create_WithSC_WillCallCreateOnASingleChoiceQuestion()
        {
            var mockSingleChoiceQuestion = new Mock<IChoiceQuestionFactory>();
            var questionFactory = new QuestionFactory { SingleChoiceQuestion = mockSingleChoiceQuestion.Object };

            questionFactory.Create(new StringReader("SC Sex 2 Female Male"));

            mockSingleChoiceQuestion.Verify(m => m.Create(It.IsAny<string>()), Times.Once());
        }

        [Test]
        public void Create_WithMC_WillCallCreateOnMultipleChoiceQuestion()
        {
            var mockMultipleChoiceQuestion = new Mock<IChoiceQuestionFactory>();
            var questionFactory = new QuestionFactory { MultipleChoiceQuestion = mockMultipleChoiceQuestion.Object };

            questionFactory.Create(new StringReader("MC Optiuni 3 op1 op2 op3"));

            mockMultipleChoiceQuestion.Verify(m => m.Create(It.IsAny<string>()));
        }
    }
}