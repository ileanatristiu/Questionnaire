using Formular;
using NUnit.Framework;

namespace FormularFactory.Test
{
    [TestFixture]
    public class SingleChoiceQuestionFactoryTests
    {
        [Test]
        public void Create_Always_WillCreateASingleChoceQuestion()
        {
            var singleChoiceQuestionFactory = new SingleChoiceQuestionFactory();

            ChoiceQuestion choiceQuestion = singleChoiceQuestionFactory.Create("SC Sex 2 Female Male");

            Assert.IsInstanceOf(typeof(SingleChoiceQuestion), choiceQuestion);
        }

        [Test]
        public void Create_Always_WillSetTheListOfAnswers()
        {
            var singleChoiceQuestionFactory = new SingleChoiceQuestionFactory();

            ChoiceQuestion choiceQuestion = singleChoiceQuestionFactory.Create("SC Sex 2 Female Male");

            Assert.AreEqual(2, choiceQuestion.Items.Count);
        }
    }
}