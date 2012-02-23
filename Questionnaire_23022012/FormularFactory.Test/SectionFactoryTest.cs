using System.IO;
using NUnit.Framework;

namespace FormularFactory.Test
{
    [TestFixture]
    public class SectionFactoryTest
    {
        [Test]
        public void Create_Always_WillCreateASectionWithName()
        {
            var sectionFactory = new SectionFactory(new QuestionFactory());

            var section = sectionFactory.Create(new StringReader("Sec1 0"));

            Assert.AreEqual("Sec1", section.Name);
        }

        [Test]
        public void Create_WhenSectionContainsQuestions_WillSetTheListOfItems()
        {
            var sectionFactory = new SectionFactory(new QuestionFactory());

            var section = sectionFactory.Create(new StringReader(@"Sec1 1
Q1 Name"));

            Assert.AreEqual(1,section.Items.Count);
        }
    }
}