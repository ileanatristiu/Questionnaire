using Formular;
using NUnit.Framework;

namespace FormularFactory.Test
{
    [TestFixture]
    public class SingleChoiceQuestionTest
    {
        [Test]
        public void Create_SC_AlwaysWillCreateASingleChoiceQuestion()
        {
            var singleChoiceQuestion = new SingleChocieQuestionFactory();

            Base choiceQuestion = singleChoiceQuestion.Create("SC Sex 2 Female Male");

            Assert.AreEqual("Sex", choiceQuestion.Name);
        }

        [Test]
        public void Create_WhenQuestionHasPossibleAnswers_WillSetTheListOfItems()
        {
            var singleChoiceQuestion = new SingleChocieQuestionFactory();

            Base choiceQuestion = singleChoiceQuestion.Create("SC Sex 2 Female Male");

            Assert.AreEqual(2, choiceQuestion.Items.Count);
        }
    }
}