using System.IO;
using Formular;

namespace FormularFactory
{
    public class QuestionFactory : IQuestionFactory
    {
        public IQuestion CreateQuestion(StringReader input)
        {
            string[] line = input.ReadLine().Split();
            IQuestion question = new FreeTextQuestion();
            question.Text = line[1];

            return question;
        }
    }
}