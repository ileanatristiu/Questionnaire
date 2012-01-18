using System.Collections.Generic;

namespace Formular
{
    public interface ISection
    {
        string Name { get; set; }

        List<IQuestion> Questions { get; set; } 
    }
}