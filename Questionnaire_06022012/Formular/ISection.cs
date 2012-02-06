using System.Collections.Generic;

namespace Formular
{
    public interface ISection
    {
        string Name { get; set; }

        int Index { get; set; }

        List<IQuestion> Questions { get; set; }

    }
}