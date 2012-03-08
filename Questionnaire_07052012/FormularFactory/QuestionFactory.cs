using System.IO;
using Formular;

namespace FormularFactory
{
    public class QuestionFactory : IQuestionFactory
    {
        public IChoiceQuestionFactory SingleChoiceQuestion { get; set; }

        public IChoiceQuestionFactory MultipleChoiceQuestion { get; set; }

        public Base Create(StringReader input)
        {
            Question question = null;
            var readLine = input.ReadLine();
            var strings = readLine.Split();
            if (strings[0] == "FT")
            {
                question = new FreeTextQuestion();
            }
            if (strings[0] == "SC")
            {
                question = SingleChoiceQuestion.Create(readLine);
            }
            if (strings[0] == "MC")
            {
                question = MultipleChoiceQuestion.Create(readLine);
            }

            return question;
        }
    }
}