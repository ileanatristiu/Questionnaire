using Formular;
using NUnit.Framework;

namespace FormularFactory.Test
{
    [TestFixture]
    public class SingleChoiceQuestionFactoryTests
    {
        [Test]
        public void Create_WhenSC_AlwaysWillCreateASingleChocieQuestion()
        {
            var singleChoiceQuestionFactory = new SingleChoiceQuestionFactory();

            var question = singleChoiceQuestionFactory.Create("SC Sex 2 Female Male");

            Assert.IsInstanceOf(typeof(SingleChoiceQuestion), question);
        }

        [Test]
        public void Create_Always_WillSetTheListOfPossibleAnswers()
        {
            var singleChoiceQuestionFactory = new SingleChoiceQuestionFactory();

            var question = singleChoiceQuestionFactory.Create("SC Sex 2 Female Male");

            Assert.AreEqual(2, question.Items.Count);
        }
    }
}