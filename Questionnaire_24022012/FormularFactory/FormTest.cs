using Formular;
using NUnit.Framework;

namespace FormularFactory
{
    [TestFixture]
    public class FormTest
    {
        [Test]
        public void ToString_WillreturnTheCorrectFormat()
        {
            var form = new Form { Name = "Formular" };
            form.Items.Add(new Page { Name = "Page", Items = new ItemsCollection { new Section { Name = "Sec" } } });

            var s = form.ToString();

            Assert.IsTrue(s.Contains("Formular"));
            Assert.IsTrue(s.Contains(@" Page
  Sec"));
        }
    }
}