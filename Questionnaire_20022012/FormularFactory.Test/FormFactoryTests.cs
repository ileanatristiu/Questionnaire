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
        public void Create_Always_WillReturnAFormWithName()
        {
            Mock<IPageFactory> mockPage = new Mock<IPageFactory>();
            var formFactory = new FormFactory(mockPage.Object);

            Base form = formFactory.Create(new StringReader("Formular 0"));

            Assert.IsInstanceOf(typeof(Form), form);
            Assert.AreEqual("Formular", form.Name);
        }

        [Test]
        public void Create_WhenHasFormHAsPages_WillSetTheListOfItems()
        {
            Mock<IPageFactory> mockPage = new Mock<IPageFactory>();
            var formFactory = new FormFactory(mockPage.Object);

            Base form = formFactory.Create(new StringReader(@"Formular 1
Page "));

            Assert.AreEqual(1, form.Items.Count);
        }
    }
}