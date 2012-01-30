using System;
using System.IO;
using Formular;

namespace FormularFactory
{
    public class PageFactory : IPageFactory
    {
        public ISectionFactory SectionFactory { get; set; }

        public IPage CreatePage(StringReader input)
        {
            IPage page = new Page();
            string line = input.ReadLine();
            string[] splitLine = line.Split();
            page.Name = splitLine[0];
            for (int i = 0; i < Convert.ToInt16(splitLine[1]); i++)
            {
                page.Sections.Add(SectionFactory.CreateSection(input));
            }

            return page;
        }
    }
}
