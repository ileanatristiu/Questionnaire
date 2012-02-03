using System;
using System.IO;
using Formular;

namespace FormularFactory
{
    public class PageFactory : IPageFactory
    {
        public ISectionFactory SectionFactory { get; set; }

        public IPage CreatePage(StringReader input, int index = 0)
        {
            IPage page = new Page();
            string[] line = input.ReadLine().Split();
            page.Name = line[0];
            page.Index = index;
            for (int i = 0; i < Convert.ToInt16(line[1]); i++)
            {
                page.Sections.Add(SectionFactory.CreateSection(input, page.Sections.Count + 1));
            }

            return page;
        }
    }
}
