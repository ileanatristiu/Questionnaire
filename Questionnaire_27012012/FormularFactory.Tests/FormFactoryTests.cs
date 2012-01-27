using System.IO;
using Formular;
using NUnit.Framework;

namespace FormularFactory.Tests
{
    [TestFixture]
    public class FormFactoryTests
    {
        [Test]
        public void CreateForm_Always_WillCreateAForm()
        {
            FormFactory formFactory = new FormFactory();

            var form = formFactory.CreateForm(new StringReader("Form "));

            Assert.IsInstanceOf(typeof(IForm), form);
        }
    }
}
