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
        public void CreateSection_Always_WillReturnASectionWithName()
        {
            var sectionFactory = new SectionFactory();

            ISection section = sectionFactory.CreateSection(new StringReader("Section 0"));

            Assert.AreEqual("Section", section.Name);
        }

        [Test]
        public void CreateSection_WhenContainsQuestions_WillSetTheListOfQuestions()
        {
            var mockQuestionFactory = new Mock<IQuestionFactory>();
            var sectionFactory = new SectionFactory { QuestionFactory = mockQuestionFactory.Object };

            ISection section = sectionFactory.CreateSection(new StringReader(@"Section 1
Q1 Name"));

            Assert.AreEqual(1, section.Questions.Count);
        }
    }
}