using System.Collections.Generic;

namespace Formular
{
    public class Page : IPage
    {
        public string Name { get; set; }

        public IList<ISection> Sections { get; set; }

        public Page()
        {
            Sections = new List<ISection>();
        }
    }
}
