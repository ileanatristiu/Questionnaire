using Formular;
using NUnit.Framework;

namespace FormularFactory.Test
{
    [TestFixture]
    public class SingleChoiceQuestionFactoryTests
    {
        [Test]
        public void Create_Always_WillReturnANewSingleChoiceQuestion()
        {
            var singleChoiceQuestionFactory = new SingleChoiceQuestionFactory();

            ChoiceQuestion choiceQuestion = singleChoiceQuestionFactory.Create("SC Sex 2 Female Male");

            Assert.IsInstanceOf(typeof(SingleChoiceQuestion), choiceQuestion);
        }

        [Test]
        public void Create_Always_WillSetTheListOfPssiblwAnswers()
        {
            var singleChoiceQuestionFactory = new SingleChoiceQuestionFactory();

            ChoiceQuestion choiceQuestion = singleChoiceQuestionFactory.Create("SC Sex 2 Female Male");

            Assert.AreEqual(2, choiceQuestion.Items.Count);
            Assert.AreEqual("Female", choiceQuestion.Items[0].Name);
            Assert.AreEqual("Male", choiceQuestion.Items[1].Name);
        }
    }
}