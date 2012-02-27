using System.IO;
using Formular;

namespace FormularFactory
{
    public class QuestionFactory : BaseFactory<Question>, IQuestionFactory
    {
        public IChoiceQuestionFactory SingleChoiceQuestion { get; set; }

        public override Base Create(StringReader input)
        {
            string[] line = input.ReadLine().Split();
            Base question = null;
            switch (line[1])
            {
                case "FT":
                    question = new FreeTextQuestion();
                    break;
                case "SC":
                    question = SingleChoiceQuestion.Create(input);
                    break;
            }
            return question;
        }
    }
}