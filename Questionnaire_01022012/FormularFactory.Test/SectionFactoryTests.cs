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
        public void CreateSection_WillreturnASctionWithName()
        {
            SectionFactory sectionFactory = new SectionFactory();

            var section = sectionFactory.CreateSection(new StringReader("Sec1 "));

            Assert.IsInstanceOf(typeof(ISection), section);
            Assert.AreEqual("Sec1", section.Name);
        }

        [Test]
        public void CreateSection_WhenSectionHasQuestions_WillPopulateTheListWithQuestions()
        {
            Mock<IQuestionFactory> mockQuestionFactory = new Mock<IQuestionFactory>();
            SectionFactory sectionFactory = new SectionFactory { QuestionFactory = mockQuestionFactory.Object };

            var section = sectionFactory.CreateSection(new StringReader(@"Sec1 1
Q1 Name"));

            Assert.AreEqual(1, section.Questions.Count);
        }
    }
}
