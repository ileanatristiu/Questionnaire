﻿using System.IO;
using Formular;

namespace FormularFactory
{
    public class FormFactory : IFormFactory
    {
        public IForm CreateForm(StringReader sr)
        {
            Form form = new Form();

            return form;
        }
    }
}
