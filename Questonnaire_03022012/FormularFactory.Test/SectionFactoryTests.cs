using System.IO;
using Formular;
using Moq;
using NUnit.Framework;

namespace FormularFactory.Test
{
    [TestFixture]
    public class SectionFactoryTests
    {
        private SectionFactory _sectionFactory;

        [SetUp]
        public void SetUp()
        {
            Mock<IQuestionFactory> mockQuestion = new Mock<IQuestionFactory>();
            _sectionFactory = new SectionFactory { QuestionFactory = mockQuestion.Object };
        }

        [Test]
        public void CreateSection_WillCreateAsectionWithName()
        {
            var section = _sectionFactory.CreateSection(new StringReader("Section 0"));

            Assert.IsInstanceOf(typeof(ISection), section);
            Assert.AreEqual("Section", section.Name);
        }

        [Test]
        public void CeateSection_willCreatwASectionWithQuestions()
        {
            var section = _sectionFactory.CreateSection(new StringReader(@"Sec1 1
Q1 Nme"));

            Assert.AreEqual(1, section.Questions.Count);
        }

        [Test]
        public void CreateSection_WillSetTheProperIndex()
        {
            var section = _sectionFactory.CreateSection(new StringReader("Sec1 0"), 1);

            Assert.AreEqual(1, section.Index);
        }
    }
}
