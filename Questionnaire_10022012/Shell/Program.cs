using System.IO;
using Formular;
using FormularFactory;
using Ninject;
using Shell.Properties;

namespace Shell
{
    class Program
    {
        static void Main(string[] args)
        {
            IKernel kernel = new StandardKernel();
            kernel.Load<Module>();

            IFormFactory formFactory = kernel.Get<IFormFactory>();

            StringReader stringReader = new StringReader(Resources._in);

            IForm form = formFactory.CreateForm(stringReader);


        }
    }
}
