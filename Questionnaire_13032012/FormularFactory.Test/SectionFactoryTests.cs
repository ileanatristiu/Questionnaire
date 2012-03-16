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
        public void Create_Always_WillCreateASectionWithNameSet()
        {
            var sectionFactory = new SectionFactory(new QuestionFactory());

            Base section = sectionFactory.Create(new StringReader("Sec1 0"));

            Assert.IsInstanceOf(typeof(Section), section);
            Assert.AreEqual("Sec1", section.Name);
        }

        [Test]
        public void Create_WhenSectionHasQuestions_WillSetTheListOfItems()
        {
            var mockQuestionFactory = new Mock<IQuestionFactory>();
            var sectionFactory = new SectionFactory(mockQuestionFactory.Object);

            Base section = sectionFactory.Create(new StringReader(@"Sec1 2
FT Nume
FT Prenume"));

            Assert.AreEqual(2, section.Items.Count);
        }
    }
}