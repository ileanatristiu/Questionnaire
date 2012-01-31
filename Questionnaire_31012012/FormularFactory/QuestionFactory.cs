using System.IO;
using Formular;

namespace FormularFactory
{
    public class QuestionFactory : IQuestionFactory
    {
        public IQuestion CreateQuestion(StringReader sr)
        {
            string line = sr.ReadLine();

            return new FreeTextQuestion();
        }
    }
}
