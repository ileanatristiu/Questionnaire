using System;
using System.IO;
using Formular;

namespace FormularFactory
{
    public class PageFactory : IPageFactory
    {
        public ISectionaFactory SectionFactory { get; set; }

        public IPage CreatePage(StringReader sr)
        {
            var readLine = sr.ReadLine();
            string[] splitLine = readLine.Split();
            IPage page = new Page();
            page.Name = splitLine[0];
            for (int i = 0; i < Convert.ToInt16(splitLine[1]); i++)
            {
                page.Sections.Add(SectionFactory.CreateSection(sr));
            }

            return page;
        }
    }
}
