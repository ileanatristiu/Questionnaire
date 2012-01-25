using Formular;
using Moq;
using NUnit.Framework;

namespace FormularFactory.Tests
{
    [TestFixture]
    public class QuestionFactoryTests
    {
        private QuestionFactory _questionFactory;
        private Mock<IChoiceQuestionFactory> _mock;
        private Mock<IChoiceQuestionFactory> _mockMultiple;

        [SetUp]
        public void SetUp()
        {
            _mock = new Mock<IChoiceQuestionFactory> { DefaultValue = DefaultValue.Mock };
            _mockMultiple = new Mock<IChoiceQuestionFactory> { DefaultValue = DefaultValue.Mock };
            _questionFactory = new QuestionFactory { SingleChoiceQuestion = _mock.Object, MultipleChoiceQuestion = _mockMultiple.Object };
        }

        [Test]
        public void CreateQuestion_WithFT_WillCreateAFreeTextQuestion()
        {
            var question = _questionFactory.CreateQuestion("Q1 FT Numele");

            Assert.IsInstanceOf(typeof(FreeTextQuestion), question);
        }

        [Test]
        public void CreateQuestion_WithSC_WillCallCreateChoiceQuestion()
        {
            const string input = "Q2 SC Sex 2 Female Male";

            _questionFactory.CreateQuestion(input);

            _mock.Verify(m => m.CreateChoiceQuestion(input));
        }

        [Test]
        public void CreateQuestion_WithMC_WillCallCreateChoiceQuestion()
        {
            const string input = "Q2 MC Optiuni 2 Female Male";

            _questionFactory.CreateQuestion(input);

            _mockMultiple.Verify(m => m.CreateChoiceQuestion(input));
        }

        [Test]
        public void CreateQuestion_Always_WillSetTheText()
        {
            const string input = "Q2 SC Sex 2 Female Male";
            _mock.Setup(m => m.CreateChoiceQuestion(input)).Returns(new SingleChoiceQuestion());

            var question = _questionFactory.CreateQuestion(input);

            Assert.That("Sex", Is.EqualTo(question.Text));
        }
    }
}
