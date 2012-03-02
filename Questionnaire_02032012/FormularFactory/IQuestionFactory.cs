using System.IO;
using Formular;

namespace FormularFactory
{
    public interface IQuestionFactory
    {
        Question Create(StringReader input);
    }
}