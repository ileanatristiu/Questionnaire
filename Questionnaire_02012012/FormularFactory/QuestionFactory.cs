using System.IO;
using Formular;

namespace FormularFactory
{
    public class QuestionFactory : IQuestionFactory
    {
        public IQuestion CreateQuestion(StringReader input)
        {
            string line = input.ReadLine();

            return new FreeTextQuestion();
        }
    }
}
