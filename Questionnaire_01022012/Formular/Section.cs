using System;
using System.Collections.Generic;
using Enumerable = System.Linq.Enumerable;

namespace Formular
{
    public class Section : ISection
    {
        public string Name { get; set; }

        public List<IQuestion> Questions { get; set; }

        public Section()
        {
            Questions = new List<IQuestion>();
        }

        public override string ToString()
        {
            string s = string.Concat(new string(' ', 2), Name);

            return Enumerable.Aggregate(Questions, s, (current, question) => string.Concat(current, Environment.NewLine, question));
        }
    }
}
