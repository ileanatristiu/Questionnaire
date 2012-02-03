using System.IO;
using Formular;

namespace FormularFactory
{
    public class QuestionFactory : IQuestionFactory
    {
        public IQuestion CreateQuestion(StringReader input)
        {
            input.ReadLine();
            return new FreeTextQuestion();
        }
    }
}
