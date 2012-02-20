using System.IO;
using Formular;
using NUnit.Framework;

namespace FormularFactory.Test
{
    [TestFixture]
    public class SectionFactoryTests
    {
        [Test]
        public void Create_Always_WillCreateASectionWithName()
        {
            var sectionFactory = new SectionFactory();

            Base section = sectionFactory.Create(new StringReader("Section"));

            Assert.AreEqual("Section", section.Name);
        }

        [Test]
        public void Create_WhenSectionHAsQuestions_WillReturnASectionWithAListOfQuestions()
        {
            var sectionFactory = new SectionFactory();

            var section = sectionFactory.Create(new StringReader(@"Section 1
Q1 Name"));

           // Assert.AreEqual(1, section.);
        }
    }
}