using System;
using System.IO;
using Formular;

namespace FormularFactory
{
    public class FormFactory : IFormFactory
    {
        public IPageFactory PageFactory { get; set; }

        public IForm CreateForm(StringReader input)
        {
            string[] line = input.ReadLine().Split();
            IForm form = new Form();
            form.Name = line[0];
            for (int i = 0; i < Convert.ToInt16(line[1]); i++)
            {
                form.Pages.Add(PageFactory.CreatePage(input, form.Pages.Count));
            }

            return form;
        }
    }
}