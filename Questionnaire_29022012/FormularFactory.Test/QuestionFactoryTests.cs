using System.IO;
using Formular;
using NUnit.Framework;

namespace FormularFactory.Test
{
    [TestFixture]
    public class QuestionFactoryTests
    {
        [Test]
        public void Create_WithFT_WillCreateAFreeTextQuestion()
        {
            var questionFactory = new QuestionFactory();

            Base question = questionFactory.Create(new StringReader("FT Name"));

            Assert.IsInstanceOf(typeof(FreeTextQuestion), question);
        }

        [Test]
        public void Create_WithSC_WillCreateASingleChoiceQuestion()
        {
            var questionFactory = new QuestionFactory();

            Base question = questionFactory.Create(new StringReader("SC Sex 2 Female Male"));

            Assert.IsInstanceOf(typeof(SingleChoiceQuestion), question);
        }
    }
}