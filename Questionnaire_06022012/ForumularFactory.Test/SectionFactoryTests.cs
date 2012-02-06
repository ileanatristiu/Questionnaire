using System.IO;
using Formular;
using FormularFactory;
using Moq;
using NUnit.Framework;

namespace ForumularFactory.Test
{
    [TestFixture]
    public class SectionFactoryTests
    {
        private SectionFactory _sectionFactory;

        [SetUp]
        public void Setup()
        {
            Mock<IQuestionFactory> mockQuestion = new Mock<IQuestionFactory>();
            _sectionFactory = new SectionFactory { QuestionFactory = mockQuestion.Object };
        }

        [Test]
        public void CreateSection_Always_WillCreateAsectionWithName()
        {
            var section = _sectionFactory.CreateSection(new StringReader("Sec1 0"));

            Assert.IsInstanceOf(typeof(ISection), section);
            Assert.AreEqual("Sec1", section.Name);
        }

        [Test]
        public void CreateSection_WhenHasQuestions_WillSetTheQuestionsList()
        {
            var section = _sectionFactory.CreateSection(new StringReader(@"Sec1 1
Q1 Name"));

            Assert.AreEqual(1, section.Questions.Count);
        }

        [Test]
        public void CreateSection_Always_WillSetTheIndex()
        {
            var section = _sectionFactory.CreateSection(new StringReader("Sec1 0"), 2);

            Assert.AreEqual(2, section.Index);
        }
    }
}