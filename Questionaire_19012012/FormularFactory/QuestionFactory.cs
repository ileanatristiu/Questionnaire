using System.IO;
using Formular;

namespace FormularFactory
{
    public class QuestionFactory : IQuestionFactory
    {
        public override IQuestion CreateQuestion(StringReader input)
        {
            IQuestion question = null;
            string line = input.ReadLine();
            string[] split = line.Split();
            if (split[1] == "FT")
            {
                question = new FreeTextQuestion();
                question.Text = split[2];
            }

            return question;
        }
    }
}
