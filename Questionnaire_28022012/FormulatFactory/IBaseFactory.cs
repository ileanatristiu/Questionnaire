using System.IO;
using Formular;

namespace FormulatFactory
{
    public interface IBaseFactory
    {
        Base Create(StringReader input);
    }
}