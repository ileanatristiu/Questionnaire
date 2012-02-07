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
        public void CreateForm_WhenHasPages_WillSetPagesListOfTheForm()
        {
            Mock<IPageFactory> mockPage = new Mock<IPageFactory> { DefaultValue = DefaultValue.Mock };
            FormFactory formFactory = new FormFactory { PageFactory = mockPage.Object };

            var form = formFactory.CreateForm(new StringReader(@"Form1 1
Page 0"));

            Assert.AreEqual(1, form.Pages.Count);
        }
    }
}