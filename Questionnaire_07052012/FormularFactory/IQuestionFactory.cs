using System.IO;
using Formular;

namespace FormularFactory
{
    public interface IQuestionFactory
    {
        Base Create(StringReader input);
    }
}