using System.IO;
using Formular;
using Moq;
using NUnit.Framework;

namespace FormularFactory.Tests
{
    [TestFixture]
    public class SectionFactoryTests
    {
        private Mock<IQuestionFactory> _mock;
        private SectionFactory _sectionFactory;

        [SetUp]
        public void SetUp()
        {
            _mock = new Mock<IQuestionFactory> { DefaultValue = DefaultValue.Mock };
            _sectionFactory = new SectionFactory { QuestionFactory = _mock.Object };
        }

        [Test]
        public void CreateSection_Always_WillCreateASection()
        {
            var section = _sectionFactory.CreateSection(new StringReader(@"Sec1 1"));

            Assert.IsInstanceOf(typeof(ISection), section);
            Assert.That("Sec1", Is.EqualTo(section.Name));
        }

        [Test]
        public void CreateSection_Always_WillCreateASectionWithQuestions()
        {
            ISection section = _sectionFactory.CreateSection(new StringReader(@"Sec1 2
Q1 FT Numele
Q2 FT Prenumele"));

            Assert.That(2, Is.EqualTo(section.Questions.Count));
            Assert.IsInstanceOf(typeof(IQuestion), section.Questions[0]);
        }
    }
}
