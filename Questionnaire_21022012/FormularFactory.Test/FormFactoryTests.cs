using System.IO;
using Formular;
using NUnit.Framework;

namespace FormularFactory.Test
{
    [TestFixture]
    public class FormFactoryTests
    {
        [Test]
        public void Create_Always_WillCreateAForm()
        {
            var formFactory = new FormFactory(new PageFactory());

            var form = formFactory.Create(new StringReader(@"Form 2
Page1 0
PAge2 0"));

            Assert.AreEqual("Form", form.Name);
            Assert.AreEqual(2, form.Items.Count);
        }
    }
}