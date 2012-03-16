using NUnit.Framework;

namespace Formular.Test
{
    [TestFixture]
    public class SingleChoiceQuestionTests
    {
        [Test]
        public void ToString_WillReturnTheCorrectFormat()
        {
            var singleChoiceQuestion = new SingleChoiceQuestion
                                           {
                                               Name = "Text",
                                               Items = new ItemsCollection { new PossibleAnswer { Name = "A1" }, new PossibleAnswer { Name = "A2" } }
                                           };

            string s = singleChoiceQuestion.ToString();

            Assert.AreEqual("   |A1|A2|", s);
        }
    }
}