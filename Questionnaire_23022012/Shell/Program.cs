using System.IO;
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

            var stringReader = new StringReader(Resources._in);

            var form = formFactory.Create(stringReader);
        }
    }
}
