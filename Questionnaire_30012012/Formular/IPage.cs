using System.Collections.Generic;

namespace Formular
{
    public interface IPage
    {
        string Name { get; set; }

        IList<ISection> Sections { get; set; }
    }
}