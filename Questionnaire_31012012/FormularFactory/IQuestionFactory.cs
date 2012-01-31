using System.IO;
using Formular;

namespace FormularFactory
{
    public interface IQuestionFactory
    {
        IQuestion CreateQuestion(StringReader sr);
    }
}