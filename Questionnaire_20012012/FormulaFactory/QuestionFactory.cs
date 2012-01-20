using System.Text.RegularExpressions;
using Formular;

namespace FormulaFactory
{
    public class QuestionFactory : IQuestionFactory
    {
        public IQuestion CreateQuestion(string input)
        {
            IQuestion question = null;
            Regex pattern = new Regex(@"\sFT\s");
            if (pattern.Matches(input).Count == 1)
            {
                question = new FreeTextQuestion();
            }

            return question;
        }
    }
}
