using System;
using System.Collections.Generic;
using System.Linq;

namespace Formular
{
    public class Page : IPage
    {
        public string Name { get; set; }

        public List<ISection> Sections { get; set; }

        public Page()
        {
            Sections = new List<ISection>();
        }

        public override string ToString()
        {
            string s = string.Concat(new string(' ', 1), Name);

            return Sections.Aggregate(s, (current, section) => string.Concat(current, string.Format("{0}{1}", Environment.NewLine, section.ToString())));
        }
    }
}
