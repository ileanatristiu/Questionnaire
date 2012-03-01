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

            string line = input.ReadLine();
            string[] lineSplit = line.Split();

            switch (lineSplit[0])
            {
                case "FT": question = new FreeTextQuestion();
                    break;
                case "SC": question = SingleChoiceQuestion.Create(line);
                    break;
            }

            return question;
        }
    }
}