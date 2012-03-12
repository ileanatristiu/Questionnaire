﻿using System.IO;
using Formular;
using Moq;
using NUnit.Framework;

namespace FormularFactory.Test
{
    [TestFixture]
    public class QuestionFactoryTests
    {
        [Test]
        public void Create_WhenFT_WillReturnAFreeTextQuestion()
        {
            var questionFactory = new QuestionFactory();

            Base question = questionFactory.Create(new StringReader("FT Name"));

            Assert.IsInstanceOf(typeof(FreeTextQuestion), question);
        }


        [Test]
        public void Create_WhenSC_WillCallCreateASingleChoiceQuestion()
        {
            var mockChoiceQuestion = new Mock<IChoiceQuesitonFactory>();
            var questionFactory = new QuestionFactory { SingleChoiceQuestion = mockChoiceQuestion.Object };

            Base question = questionFactory.Create(new StringReader("SC Sex 2 Female Male"));

            mockChoiceQuestion.Verify(m => m.Create(It.IsAny<string>()), Times.Once());
        }
    }
}