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
        public void CreateSection_Always_WillCreateASection()
        {
            SectionFactory sectionFactory = new SectionFactory();

            var section = sectionFactory.CreateSection(new StringReader(@"Sec1 1
Q1 FT Numele"));

            Assert.IsInstanceOf(typeof(ISection), section);
            Assert.That("Sec1", Is.EqualTo(section.Name));
        }

        [Test]
        public void CreateSection_Always_WillCreateASectionWithAListOfQuestions()
        {
            Mock<IQuestionFactory> mock = new Mock<IQuestionFactory>{DefaultValue = DefaultValue.Mock};
            SectionFactory sectionFactory = new SectionFactory{Question = mock.Object};

            var section = sectionFactory.CreateSection(new StringReader(@"Sec1 2
Q1 FT Numele
Q2 Ft Prenumele"));

            Assert.That("Sec1", Is.EqualTo(section.Name));
            Assert.That(section.Questions.Count, Is.EqualTo(2));
        }
    }
}
