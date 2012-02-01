using System.Collections.Generic;
using NUnit.Framework;

namespace Formular.Test
{
    [TestFixture]
    public class SectionTests
    {
        [Test]
        public void ToString_WillReturnTheCorectFormat()
        {
            Section section = new Section { Name = "Sec1", Questions = new List<IQuestion> { new FreeTextQuestion(), new FreeTextQuestion() } };

            var s = section.ToString();

            Assert.IsTrue(s.Contains("  Sec1"));
            Assert.IsTrue(s.Contains(@"  Sec1
   ___"));
        }
    }
}
