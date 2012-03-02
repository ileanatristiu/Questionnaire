using System.IO;
using Formular;

namespace FormularFactory
{
    public class QuestionFactory : IQuestionFactory
    {
        public IChoiceQuestionFactory SingleChoiceQuestion { get; set; }

        public Question Create(StringReader input)
        {
            Question question = null;
            string line = input.ReadLine();
            string[] lineSplit = line.Split();
            if (lineSplit[0] == "SC")
            {
                question = SingleChoiceQuestion.Create(line);
            }

            return question;
        }
    }
}