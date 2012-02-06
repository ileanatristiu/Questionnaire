using System.IO;
using Formular;
using FormularFactory;
using NUnit.Framework;

namespace ForumularFactory.Test
{
    [TestFixture]
    public class FormFactoryTests
    {
        [Test]
        public void CreateForm_Always_WillCreateAFormWithName()
        {
            FormFactory formFactory = new FormFactory();

            var form = formFactory.CreateForm(new StringReader("Form"));

            Assert.IsInstanceOf(typeof(IForm), form);
        }
    }
}