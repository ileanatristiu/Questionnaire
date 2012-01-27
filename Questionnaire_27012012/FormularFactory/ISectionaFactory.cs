using System.IO;
using Formular;

namespace FormularFactory
{
    public interface ISectionaFactory
    {
        ISection CreateSection(StringReader sr);
    }
}