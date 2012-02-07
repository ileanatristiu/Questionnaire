using System.IO;
using Formular;

namespace FormularFactory
{
    public interface IPageFactory
    {
        IPage CreatePage(StringReader input, int index);
    }
}