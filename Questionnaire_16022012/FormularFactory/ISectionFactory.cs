using System.IO;
using Formular;

namespace FormularFactory
{
    public interface ISectionFactory
    {
        ISection CreateSection(StringReader input);
    }
}