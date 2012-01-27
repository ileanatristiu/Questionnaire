using Formular;

namespace FormularFactory
{
    public class QuestionFactory : IQuestionFacrory
    {
        public IQuestion CreateQuestion(string input)
        {
            return new FreeTextQuestion();
        }
    }
}
