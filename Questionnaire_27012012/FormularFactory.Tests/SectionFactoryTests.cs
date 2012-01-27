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
        public void CreateSection_Always_WillReturnASection()
        {
            SectionFactory sectionFactory = new SectionFactory();

            var section = sectionFactory.CreateSection(new StringReader("Sec1 0"));

            Assert.IsInstanceOf(typeof(ISection), section);
            Assert.AreEqual("Sec1", section.Name);
        }

        [Test]
        public void CreateSection_Always_WillReturnASectionWithQuestions()
        {
            Mock<IQuestionFacrory> mock = new Mock<IQuestionFacrory> { DefaultValue = DefaultValue.Mock };
            SectionFactory sectionFactory = new SectionFactory { QuestionFactory = mock.Object };

            var section = sectionFactory.CreateSection(new StringReader(@"Sec1 1
Q1 Name"));

            Assert.AreEqual(1, section.Questions.Count);
        }
    }
}
