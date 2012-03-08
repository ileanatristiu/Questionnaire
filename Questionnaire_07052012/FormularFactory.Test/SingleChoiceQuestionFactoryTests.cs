using Formular;
using NUnit.Framework;

namespace FormularFactory.Test
{
    [TestFixture]
    public class SingleChoiceQuestionFactoryTests
    {
        [Test]
        public void Create_Always_WillReturnASingleChoiceQuestion()
        {
            var singleChoiceQuestionFactory = new SingleChoiceQuestionFactory();

            var choiceQuestion = singleChoiceQuestionFactory.Create("SC Sex 2 Female Male");

            Assert.IsInstanceOf(typeof(SingleChoiceQuestion), choiceQuestion);
            Assert.AreEqual("Sex", choiceQuestion.Name);
        }

        [Test]
        public void Create_Always_WillSetTheListOfPossibleAnswers()
        {
            var singleChoiceQuestionFactory = new SingleChoiceQuestionFactory();

            var choiceQuestion = singleChoiceQuestionFactory.Create("SC Sex 2 Female Male");

            Assert.AreEqual(2,choiceQuestion.Items.Count);
        }
    }
}