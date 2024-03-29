﻿using System;
using System.IO;
using Formular;
using Ninject;

namespace FormularFactory
{
    public class PageFactory : IPageFactory
    {
        [Inject]
        public ISectionFactory SectionFactory { get; set; }

        public IPage CreatePage(StringReader input)
        {
            string[] line = input.ReadLine().Split();
            IPage page = new Page();
            page.Name = line[0];
            for (int i = 0; i < Convert.ToInt16(line[1]); i++)
            {
                page.Sections.Add(SectionFactory.createSection(input));
            }

            return page;
        }
    }
}