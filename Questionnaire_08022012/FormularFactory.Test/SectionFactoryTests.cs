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

            var section = sectionFactory.CreateSection(new StringReader("Section 0"));

            Assert.IsInstanceOf(typeof(ISection), section);
            Assert.AreEqual("Section", section.Name);
        }

        [Test]
        public void CreateSection_WhenSectionHAsQuestions_WillSetTheListOfQuestions()
        {
            Mock<IQuestionFactory> mockQuestioFactory = new Mock<IQuestionFactory>();
            SectionFactory sectionFactory = new SectionFactory { QuestionFactory = mockQuestioFactory.Object };

            var section = sectionFactory.CreateSection(new StringReader(@"Section 2
Q1 Name
Q2 Age"));

            Assert.AreEqual(2, section.Questions.Count);
        }
    }
}