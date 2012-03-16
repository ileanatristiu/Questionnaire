using NUnit.Framework;

namespace Formular.Test
{
    [TestFixture]
    public class FormTests
    {
        [Test]
        public void ToString_WillreturnTheCorrectFormat()
        {
            var form = new Form { Name = "Form" };

            string s = form.ToString();

            Assert.AreEqual("Form", s);
        }
    }
}