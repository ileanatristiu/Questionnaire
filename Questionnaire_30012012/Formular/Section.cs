using System.Collections.Generic;

namespace Formular
{
    public class Section : ISection
    {
        public string Name { get; set; }

        public IList<IQuestion> Questions { get; set; }

        public Section()
        {
            Questions = new List<IQuestion>();
        }
    }
}
