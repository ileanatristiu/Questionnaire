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
        public void CreateSection_WillReturnASectionWithName()
        {
            SectionFactory sectionFactory = new SectionFactory();

            var section = sectionFactory.CreateSection(new StringReader("Sec1 0"));

            Assert.IsInstanceOf(typeof(Section), section);
            Assert.AreEqual("Sec1", section.Name);
        }

        [Test]
        public void CreateSection_WillCreateASectionWithQuestions()
        {
            Mock<IQuestionFactory> mock = new Mock<IQuestionFactory> { DefaultValue = DefaultValue.Mock };
            SectionFactory sectionFactory = new SectionFactory { QuestionFactory = mock.Object };

            var section = sectionFactory.CreateSection(new StringReader(@"Sec1 1
Q1 Name"));

            Assert.AreEqual(1, section.Questions.Count);
        }
    }
}
