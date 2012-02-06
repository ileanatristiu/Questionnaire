using System.IO;
using Formular;

namespace FormularFactory
{
    public class FormFactory : IFormFactory
    {
        public IForm CreateForm(StringReader input)
        {
            return new Form();
        }
    }
}