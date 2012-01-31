using System.IO;
using Formular;
using Moq;
using NUnit.Framework;

namespace FormularFactory.Tests
{
    [TestFixture]
    public class SectionFactoryTests
    {
        [Test]
        public void CreateSection_Always_WillCreateASectionWithNameAndListOfQuestions()
        {
            Mock<IQuestionFactory> mockQuestion = new Mock<IQuestionFactory>();
            SectionFactory sectionFactory = new SectionFactory { QuestionFactory = mockQuestion.Object };

            var section = sectionFactory.CreateSection(new StringReader(@"Sec1 1
Q1 Name"));

            Assert.IsInstanceOf(typeof(ISection), section);
            Assert.AreEqual(1, section.Questions.Count);
        }
    }
}
