using System;
using System.IO;
using System.Text.RegularExpressions;
using Formular;
using Ninject;

namespace FormularFactory
{
    public class QuestionFactory : BaseFactory<Question>, IQuestionFactory
    {
        [Inject, SingleChoice]
        public IChoiceQuestionFactory SingleChoiceQuestionFactory { get; set; }

        [Inject, MultipleChoice]
        public IChoiceQuestionFactory MultipleChoiceQuestionFactory { get; set; }

        public override Base Create(StringReader input)
        {
            string line = input.ReadLine();
            Base question = null;
            if (line.StartsWith("FT"))
            {
                question = new FreeTextQuestion();
            }
            if (Regex.Match(line, @"SC ").Success)
            {
                question = SingleChoiceQuestionFactory.CreateChoiceQuestion(line);
            }

            if (Regex.Match(line, @"MC ").Success)
            {
                question = MultipleChoiceQuestionFactory.CreateChoiceQuestion(line);
            }

            return question;
        }
    }

    public class MultipleChoiceAttribute : Attribute
    {
    }

    public class SingleChoiceAttribute : Attribute
    {
    }
}