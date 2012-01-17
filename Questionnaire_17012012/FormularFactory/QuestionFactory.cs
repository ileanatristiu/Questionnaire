using Formular;

namespace FormularFactory
{
    public class QuestionFactory : IQuestionFactory
    {
        

        public IQuestion CreateQuestion(string input)
        {
            IQuestion question = null;
            string[] splitInput = input.Split();

            if (splitInput[1] == "FT")
            {
                question = new FreeTextQuestion();
            }
            if (splitInput[1] == "SC")
            {
                question = new SingleChoiceQuestion();
            }

            question.Text = splitInput[2];
            return question;
        }
    }
}
