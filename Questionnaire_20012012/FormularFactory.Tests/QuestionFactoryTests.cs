using FormulaFactory;
using Formular;
using NUnit.Framework;

namespace FormularFactory.Tests
{
    [TestFixture]
    public class QuestionFactoryTests
    {
        [Test]
        public void CreateQuestion_WillCreateAQuestion()
        {
            IQuestionFactory questionFactory = new QuestionFactory();

            var question = questionFactory.CreateQuestion("Q1 FT Numele");

            Assert.IsInstanceOf(typeof(IQuestion), question);
        }
    }
}
