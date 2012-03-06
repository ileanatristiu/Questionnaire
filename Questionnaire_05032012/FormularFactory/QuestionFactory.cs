using System.IO;
using Formular;

namespace FormularFactory
{
    public class QuestionFactory : BaseFactory<Question>, IQuestionFactory
    {
        public new Base Create(StringReader input)
        {
            string readLine = input.ReadLine();
            var line = readLine.Split();
            Question question = null;
            if (line[0] == "FT")
            {
                question = new FreeTextQuestion();
            }

            return question;
        }
    }
}