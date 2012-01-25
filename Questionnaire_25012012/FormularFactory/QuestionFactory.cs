using Formular;

namespace FormularFactory
{
    public class QuestionFactory : IQuestionFactory
    {
        public IChoiceQuestionFactory SingleChoiceQuestion { get; set; }

        public IChoiceQuestionFactory MultipleChoiceQuestion { get; set; }

        public IQuestion CreateQuestion(string input)
        {
            IQuestion question = null;
            string[] splitInpu = input.Split();

            if (splitInpu[1] == "FT")
            {
                question = new FreeTextQuestion();
            }
            if (splitInpu[1] == "SC")
            {
                question = SingleChoiceQuestion.CreateChoiceQuestion(input);
            }
            if (splitInpu[1] == "MC")
            {
                question = MultipleChoiceQuestion.CreateChoiceQuestion(input);
            }
            question.Text = splitInpu[2];

            return question;
        }
    }
}
