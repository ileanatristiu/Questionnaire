using Formular;
using NUnit.Framework;

namespace FormularFactory.Tests
{
    [TestFixture]
    public class QuestionFactoryTests
    {
        private IQuestionFactory _questionFactory;

        [SetUp]
        public void SetUp()
        {
            _questionFactory = new QuestionFactory();
        }

        [Test]
        public void CreateQuestion_WithFT_ReturnsAFreeTextQuestionQuestion()
        {
            var question = _questionFactory.CreateQuestion("Q1 FT Numele");

            Assert.IsInstanceOf(typeof(FreeTextQuestion), question);
            Assert.That(question.Text, Is.EqualTo("Numele"));
        }

        [Test]
        public void CreateQuestion_WithSC_WillCreateASingleChoiceQuestion()
        {
            var question = _questionFactory.CreateQuestion("Q1 SC Sex 2 Female Male");

            Assert.That(question.Text, Is.EqualTo("Sex"));
            Assert.IsInstanceOf(typeof(SingleChoiceQuestion), question);
        }

    }
}
