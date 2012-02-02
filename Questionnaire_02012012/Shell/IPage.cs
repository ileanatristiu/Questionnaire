using System.Collections.Generic;

namespace Formular
{
    public interface IPage
    {
        string Name { get; set; }

        List<ISection> Sections { get; set; }

        int Index { get; set; }
    }
}