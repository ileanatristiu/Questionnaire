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
        public void CreateSection_Always_WilCreateASectionWithNameAndIndex()
        {
            SectionFactory sectionFactory = new SectionFactory();

            var section = sectionFactory.CreateSection(new StringReader("Sec1 0"), 1);

            Assert.IsInstanceOf(typeof(ISection), section);
            Assert.AreEqual("Sec1", section.Name);
            Assert.AreEqual(1, section.Index);
        }

        [Test]
        public void CreateSection_WhenContainsQuestions_WillSetTheQuestionsList()
        {
            Mock<IQuestionFactory> mockQuestionFactory = new Mock<IQuestionFactory>();
            SectionFactory sectionFactory = new SectionFactory { QuestionFactory = mockQuestionFactory.Object };

            var section = sectionFactory.CreateSection(new StringReader(@"Sec1 1
Q1 Name"), 2);

            Assert.AreEqual(1, section.Questions.Count);
        }
    }
}