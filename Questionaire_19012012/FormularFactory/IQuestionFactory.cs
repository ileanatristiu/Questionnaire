using System.IO;
using Formular;

namespace FormularFactory
{
    public abstract class IQuestionFactory
    {
        public abstract IQuestion CreateQuestion(StringReader input);
    }
}