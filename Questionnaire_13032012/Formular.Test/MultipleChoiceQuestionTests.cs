using NUnit.Framework;

namespace Formular.Test
{
    [TestFixture]
    public class MultipleChoiceQuestionTests
    {
        [Test]
        public void ToString_WillreturnTheCorrectFormat()
        {
            var multipleChoiceQuestion = new MultipleChoiceQuestion
                                             {
                                                 Name = "Question", Items = new ItemsCollection {new PossibleAnswer {Name = "op1"}, new PossibleAnswer {Name = "op2"}}
                                             };

            string s = multipleChoiceQuestion.ToString();

            Assert.AreEqual("   ||op1||op2||",s);
        }
    }
}