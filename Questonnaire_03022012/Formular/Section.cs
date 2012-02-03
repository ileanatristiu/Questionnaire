using System.Collections.Generic;

namespace Formular
{
    public class Section : ISection
    {
        public string Name { get; set; }

        public int Index { get; set; }

        public List<IQuestion> Questions { get; set; }

        public Section()
        {
            Questions = new List<IQuestion>();
        }

    }
}
