﻿using System.IO;
using Formular;
using NUnit.Framework;

namespace FormularFactory.Test
{
    [TestFixture]
    public class QuestionFactoryTests
    {
        [Test]
        public void CreateQuestion_Always_WillCreateAFreeTextQuestion()
        {
            var questionFactory = new QuestionFactory();

            var question = questionFactory.CreateQuestion(new StringReader("Q1 Name"));

            Assert.IsInstanceOf(typeof(FreeTextQuestion), question);
        }
    }
}