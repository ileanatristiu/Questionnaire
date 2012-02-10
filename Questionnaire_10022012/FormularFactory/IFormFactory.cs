using System.IO;
using Formular;

namespace FormularFactory
{
    public interface IFormFactory
    {
        IForm CreateForm(StringReader input);
    }
}