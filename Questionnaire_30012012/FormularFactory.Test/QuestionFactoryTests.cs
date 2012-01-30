﻿using System.IO;
using Formular;
using NUnit.Framework;

namespace FormularFactory.Test
{
    [TestFixture]
    public class QuestionFactoryTests
    {
        [Test]
        public void CreateQuestion_WillReturnAFreeTextQuestion()
        {
            QuestionFactory questionFactory = new QuestionFactory();

            var question = questionFactory.CreateQuestion(new StringReader("Q1 Numele"));

            Assert.IsInstanceOf(typeof(FreeTextQuestion), question);
        }
    }
}
