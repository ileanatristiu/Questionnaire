using Formular;
using NUnit.Framework;

namespace FormularFactory
{
    [TestFixture]
    public class SingleChoiceQuestionTests
    {
        [Test]
        public void ToString_WillReturnTheCorrectFormat()
        {
            var singleChoiceQuestion = new SingleChoiceQuestion();
            singleChoiceQuestion.Items.Add(new PossibleAnswer { Name = "option" });

            var s = singleChoiceQuestion.ToString();

            Assert.AreEqual("   |option|", s);
        }
    }
}