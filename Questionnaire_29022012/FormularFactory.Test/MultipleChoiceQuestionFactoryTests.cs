using Formular;
using NUnit.Framework;

namespace FormularFactory.Test
{
    [TestFixture]
    public class MultipleChoiceQuestionFactoryTests
    {
        [Test]
        public void Create_Always_WillCreateAmultipleChoiceQuestion()
        {
            var multipleChoiceQuestionFactory = new MultipleChoiceQuestionFactory();

            ChoiceQuestion choiceQuestion = multipleChoiceQuestionFactory.Create("MC Optiuni 3 op1 op2 op3");

            Assert.IsInstanceOf(typeof(MultipleChoiceQuestion), choiceQuestion);
        }
    }
}