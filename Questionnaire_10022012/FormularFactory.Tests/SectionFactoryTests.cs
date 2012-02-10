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
        public void CreateSection_Always_WillCreateASectionWithName()
        {
            SectionFactory sectionFactory = new SectionFactory();

            var section = sectionFactory.CreateSection(new StringReader("Section 0"));

            Assert.IsInstanceOf(typeof(ISection), section);
            Assert.AreEqual("Section", section.Name);
        }

        [Test]
        public void CreateSection_WhenHasQuestions_WillSetTheLIstOfQuestions()
        {
            Mock<IQuestionFactory> mock = new Mock<IQuestionFactory>();
            SectionFactory sectionFactory = new SectionFactory { QuestionFactory = mock.Object };

            var section = sectionFactory.CreateSection(new StringReader(@"Section 2
Q1 NAme
Q2 Age"));

            Assert.AreEqual(2, section.Questions.Count);
        }
    }
}