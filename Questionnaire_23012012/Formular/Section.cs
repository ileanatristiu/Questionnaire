using System;
using System.Collections.Generic;
using System.Linq;

namespace Formular
{
    public class Section : ISection
    {
        public string Name { get; set; }

        public List<IQuestion> Questions { get; set; }

        public override string ToString()
        {
            string s = string.Concat("  ", Name);
            string ss = Questions.Aggregate(string.Empty, (current, question) => string.Concat(current, string.Format("{0}{1}", Environment.NewLine, question.ToString())));

            return string.Format("{0}{1}{2}", s, Environment.NewLine, ss);
        }
    }
}
