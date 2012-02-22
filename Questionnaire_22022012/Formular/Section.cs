using System;
using System.Linq;

namespace Formular
{
    public class Section : Base
    {
        public override string ToString()
        {
            string s= string.Concat(new string(' ', 2), Name);
            foreach (var item in Items)
            {
                string.Concat(s, string.Format("{0}{1}", Environment.NewLine, item.ToString()));
            }
            return s;
        }
    }
}