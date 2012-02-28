using System.IO;
using Formular;

namespace FormulatFactory
{
    public class QuestionFactory : BaseFactory<Question>, IQuestionFactory
    {
        public IQuestionFactory AnswersFactory { get; set; }

        public override Base Create(StringReader input)
        {
            string[] line = input.ReadLine().Split();
            Base question = null;
            if (line[1] == "FT")
            {
                question = new FreeTextQuestion();
            }
            else
            {
                question = AnswersFactory.Create(line);
            }
            return question;
        }

        public Base Create(string[] line)
        {
            throw new System.NotImplementedException();
        }
    }
}