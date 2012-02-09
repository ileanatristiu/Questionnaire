using System.IO;
using Formular;
using Moq;
using NUnit.Framework;

namespace FormularFactory.Test
{
    [TestFixture]
    public class SectionFactoryTests
    {
        [Test]
        public void CreateSection_Always_WillCreateASectionWithName()
        {
            SectionFactory sectionFactory = new SectionFactory();

            var section = sectionFactory.createSection(new StringReader("Sec1 0"));

            Assert.IsInstanceOf(typeof(ISection), section);
            Assert.AreEqual("Sec1", section.Name);
        }

        [Test]
        public void CreateSection_WhenHAsQuestions_WillSetTheListOfQuestions()
        {
            Mock<IQuestionFactory> mockQuestion = new Mock<IQuestionFactory>();
            SectionFactory sectionFactory = new SectionFactory { QuestionFactory = mockQuestion.Object };

            var section = sectionFactory.createSection(new StringReader(@"Sec 2
Q1 Name
Q2 Adress"));

            Assert.AreEqual(2, section.Questions.Count);
        }
    }
}