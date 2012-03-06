using System.IO;
using Formular;
using NUnit.Framework;

namespace FormularFactory.Test
{
    [TestFixture]
    public class QuestionFactoryTests
    {
        [Test]
        public void Create_WhenFT_WillCeateAFreeTextQuestion()
        {
            var questionFactory = new QuestionFactory();

            var question = questionFactory.Create(new StringReader("FT Name"));

            Assert.IsInstanceOf(typeof(FreeTextQuestion), question);
        }
    }
}