using System.Collections.Generic;

namespace Formular
{
    public class Form : IForm
    {
        public string Name { get; set; }

        public List<IPage> Pages { get; set; }

        public Form()
        {
            Pages = new List<IPage>();
        }
    }
}