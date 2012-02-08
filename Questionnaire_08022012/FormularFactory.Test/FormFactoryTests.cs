using System.IO;
using Formular;
using Moq;
using NUnit.Framework;

namespace FormularFactory.Test
{
    [TestFixture]
    public class FormFactoryTests
    {
        [Test]
        public void CreateForm_Always_WillCreateAFormWithName()
        {
            FormFactory formFactory = new FormFactory();

            var form = formFactory.CreateForm(new StringReader("Form 0"));

            Assert.IsInstanceOf(typeof(IForm), form);
            Assert.AreEqual("Form", form.Name);
        }

        [Test]
        public void CreateForm_WhenFormContaisPages_WillSetTheListOfPages()
        {
            Mock<IPageFactory> mockPageFactory = new Mock<IPageFactory>();
            FormFactory formFactory = new FormFactory { PageFactory = mockPageFactory.Object };

            var form = formFactory.CreateForm(new StringReader(@"Form 1
Page 0"));

            Assert.AreEqual(1, form.Pages.Count);
        }
    }
}