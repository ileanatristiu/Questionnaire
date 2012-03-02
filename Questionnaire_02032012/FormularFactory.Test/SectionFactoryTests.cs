using System.IO;
using Formular;
using NUnit.Framework;

namespace FormularFactory.Test
{
    [TestFixture]
    public class SectionFactoryTests
    {
        [Test]
        public void Create_Always_WillReturnANewSection()
        {
            var sectionFactory = new SectionFactory();

            Base section = sectionFactory.Create(new StringReader("Sec1 0"));

            Assert.IsInstanceOf(typeof(Section), section);
            Assert.AreEqual("Sec1", section.Name);
        }

        [Test]
        public void Method_scenario_behaviour()
        {
            var sectionFactory = new SectionFactory();

            Base section = sectionFactory.Create(new StringReader(@"Sec1 1
SC Sex 2 Female Male"));

            Assert.AreEqual(1, section.Items.Count);
        }
    }
}