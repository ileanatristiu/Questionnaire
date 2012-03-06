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
        public void Create_Always_WillCreateASectionWithName()
        {
            var sectionFactory = new SectionFactory(new QuestionFactory());
            Base section = sectionFactory.Create(new StringReader("Sec1 0"));

            Assert.IsInstanceOf(typeof(Section), section);
            Assert.AreEqual("Sec1", section.Name);
        }

        [Test]
        public void Create_WhenSectionHasQuestions_WillPopulateTheListOfItems()
        {
            var mockQuestion = new Mock<IQuestionFactory>();
            var sectionFactory = new SectionFactory(mockQuestion.Object);
            Base section = sectionFactory.Create(new StringReader(@"Sec1 1
FT Name"));

            Assert.AreEqual(1, section.Items.Count);
        }
    }
}