using Formular;
using NUnit.Framework;

namespace FormularFactory.Test
{
    [TestFixture]
    public class SingleChoiceQuestionFactoryTests
    {
        [Test]
        public void Create_Always_WillSetQuestionName()
        {
            var singleChoiceQuestionFactory = new SingleChoiceQuestionFactory();

            ChoiceQuestion choiceQuestion = singleChoiceQuestionFactory.CreateChoiceQuestion("SC Sex 2 Female Male");

            Assert.IsInstanceOf(typeof(SingleChoiceQuestion), choiceQuestion);
            Assert.AreEqual("Sex", choiceQuestion.Name);
        }

        [Test]
        public void Create_Always_WillSetTheListOfAnswers()
        {
            var singleChoiceQuestionFactory = new SingleChoiceQuestionFactory();

            ChoiceQuestion choiceQuestion = singleChoiceQuestionFactory.CreateChoiceQuestion("SC Sex 2 Female Male");

            Assert.AreEqual(2, choiceQuestion.Items.Count);
            Assert.AreEqual("Female",choiceQuestion.Items[0].Name);
            Assert.AreEqual("Male",choiceQuestion.Items[1].Name);
        }
    }
}