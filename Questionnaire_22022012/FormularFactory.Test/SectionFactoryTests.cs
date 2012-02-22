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
            var sectionFactory = new SectionFactory(new QuestionFactory());

            var section = sectionFactory.Create(new StringReader("Section"));

            Assert.IsInstanceOf(typeof(Section), section);
            Assert.AreEqual("Section", section.Name);
        }

        [Test]
        public void Create_WhenItemHasChildren_WillSetTheListofItems()
        {
            var sectionFactory = new SectionFactory(new QuestionFactory());

            var section = sectionFactory.Create(new StringReader(@"Section 1
Q1 Name"));

            Assert.AreEqual(1, section.Items.Count);
        }
    }
}