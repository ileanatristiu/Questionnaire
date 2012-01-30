using System.Collections.Generic;

namespace Formular
{
    public interface ISection
    {
        string Name { get; set; }

        IList<IQuestion> Questions { get; set; }
    }
}