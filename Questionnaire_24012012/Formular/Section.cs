using System;
using System.Collections.Generic;
using System.Linq;

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

            return Questions.Aggregate(s, (current, question) => string.Concat(current, string.Format("{0}{1}", Environment.NewLine, question.ToString())));
        }
    }
}
