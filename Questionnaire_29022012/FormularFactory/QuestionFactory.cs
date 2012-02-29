using System.IO;
using Formular;

namespace FormularFactory
{
    public class QuestionFactory : IQuestionFactory
    {
        public Base Create(StringReader input)
        {
            Base question = null;
            string[] line = input.ReadLine().Split();
            if (line[0] == "FT")
            {
                question = new FreeTextQuestion();
            }
            if (line[0] == "SC")
            {
                question = new SingleChoiceQuestion();
            }

            return question;
        }
    }
}