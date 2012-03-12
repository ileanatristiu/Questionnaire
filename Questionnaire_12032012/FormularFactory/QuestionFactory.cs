using System.IO;
using System.Text.RegularExpressions;
using Formular;

namespace FormularFactory
{
    public class QuestionFactory
    {
        public IChoiceQuesitonFactory SingleChoiceQuestion { get; set; }

        public Base Create(StringReader input)
        {
            Base question = null;
            string line = input.ReadLine();
            string[] strings = line.Split();

            if (strings[0] == "FT")
            {
                question = new FreeTextQuestion();
            }

            if (strings[0] == "SC")
            {
                question = SingleChoiceQuestion.Create(line);
            }

            return question;
        }
    }
}