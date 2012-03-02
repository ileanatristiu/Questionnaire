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
        public void Create_WithSC_WillCreateASingleChoiceQuestion()
        {
            var mockChoiceQuestion = new Mock<IChoiceQuestionFactory>();
            var questionFactory = new QuestionFactory { SingleChoiceQuestion = mockChoiceQuestion.Object };

            Question question = questionFactory.Create(new StringReader("SC Sex 2 Female Male"));

            mockChoiceQuestion.Verify(m => m.Create("SC Sex 2 Female Male"), Times.Once());
        }
    }
}