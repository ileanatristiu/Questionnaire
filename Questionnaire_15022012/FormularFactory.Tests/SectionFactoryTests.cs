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
        public void CreateSection_Always_WillReturnASectionWithName()
        {
            var mock = new Mock<IQuestionFactory>();
            var sectionFactory = new SectionFactory(mock.Object);

            Base item = sectionFactory.Create(new StringReader("Section 0"));

            Assert.IsInstanceOf(typeof(Section), item);
        }

//        [Test]
//        public void CreateSection_WhenHasQuestions_WillSetTheListOfQuestions()
//        {
//            var mock = new Mock<IQuestionFactory>();
//            var sectionFactory = new SectionFactory(mock.Object);
//
//            Base item = sectionFactory.Create(new StringReader(@"Section 1
//Q1 Name"));
//
//            Assert.AreEqual(1, item.Items.Count);
//        }
    }
}