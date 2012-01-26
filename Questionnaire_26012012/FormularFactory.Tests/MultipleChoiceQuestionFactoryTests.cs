using Formular;
using NUnit.Framework;

namespace FormularFactory.Tests
{
    [TestFixture]
    public class MultipleChoiceQuestionFactoryTests
    {
        [Test]
        public void CreateChoiceQuestion_WithMC_WillCReateAMultipleChoiceQuestion()
        {
            MultipleChoiceQuestionFatory multipleChoiceQuestionFatory = new MultipleChoiceQuestionFatory();

            var choiceQuestion = multipleChoiceQuestionFatory.CreateChoiceQuestion("Q1 MC Optiuni 2 op1 op2");

            Assert.IsInstanceOf(typeof(MultipleChoiceQuestion), choiceQuestion);
        }
    }
}
