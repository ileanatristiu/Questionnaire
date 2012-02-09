using System.IO;
using Formular;

namespace FormularFactory
{
    public interface ISectionFactory
    {
        ISection createSection(StringReader input);
    }
}