using Formular;
using NUnit.Framework;

namespace FormularFactory.Tests
{
    [TestFixture]
    public class SingleChoiceQuestionFactoryTests
    {
        [Test]
        public void CreateChoiceQuestion_WithSC_WillCreateASingleChocieQuestion()
        {
            SingleChoiceQuestionFactory singleChoiceQuestionFactory = new SingleChoiceQuestionFactory();

            var choiceQuestion = singleChoiceQuestionFactory.CreateChoiceQuestion("Q1 Optiuni 2 op1 op2");

            Assert.IsInstanceOf(typeof(SingleChoiceQuestion), choiceQuestion);
        }

        [Test]
        public void CreateChoiceQuestion_WithSC_WillCreateASingleChoiceQuestionWithPossibleAnswers()
        {
            SingleChoiceQuestionFactory singleChoiceQuestionFactory = new SingleChoiceQuestionFactory();

            var choiceQuestion = singleChoiceQuestionFactory.CreateChoiceQuestion("Q1 Optiuni 2 op1 op2");

            Assert.That(2, Is.EqualTo(choiceQuestion.PossibleAnswers.Count));
            Assert.AreEqual("op1", choiceQuestion.PossibleAnswers[0]);
            Assert.AreEqual("op2", choiceQuestion.PossibleAnswers[1]);

        }
    }
}
