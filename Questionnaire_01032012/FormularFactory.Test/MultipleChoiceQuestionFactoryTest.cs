using Formular;
using NUnit.Framework;

namespace FormularFactory.Test
{
    [TestFixture]
    public class MultipleChoiceQuestionFactoryTest
    {
        [Test]
        public void Create_WhenMC_WillCreateAMultipleChoiceQuestion()
        {
            var singleChoiceQuestionFactory = new MultipleChoiceQuestionFactory();

            ChoiceQuestion choiceQuestion = singleChoiceQuestionFactory.Create("MC Optiuni 3 op1 op2 op3");

            Assert.AreEqual(3, choiceQuestion.Items.Count);
        }
    }
}