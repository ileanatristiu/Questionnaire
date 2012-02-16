using System.IO;
using Formular;
using Moq;
using NUnit.Framework;

namespace FormularFactory.Tests
{
    [TestFixture]
    public class FormFactoryTests
    {
        [Test]
        public void CreateForm_Always_WillCreateAFormWithName()
        {
            FormFactory formFactory = new FormFactory();

            var form = formFactory.Create(new StringReader("Formular 0"));

            Assert.IsInstanceOf(typeof(Form), form);
            Assert.AreEqual("Formular", form.Name);
        }

        [Test]
        public void CreateForm_WhenHasPages_WillSetTheListOfPages()
        {
            Mock<IPageFactory> mockPage = new Mock<IPageFactory>();
            FormFactory formFactory = new FormFactory { ChildFactory = mockPage.Object };

            var form = formFactory.Create(new StringReader(@"Form 1
Page 0"));

            Assert.AreEqual(1, form.Items.Count);
        }
    }
}