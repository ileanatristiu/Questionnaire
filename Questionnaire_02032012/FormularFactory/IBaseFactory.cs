using System.IO;
using Formular;

namespace FormularFactory
{
    public interface IBaseFactory
    {
        Base Create(StringReader input);
    }
}