using System;
using System.IO;
using Formular;
using FormularFactory;
using Ninject;
using Shell.Properties;

namespace Shell
{
    class Program
    {
        static void Main()
        {
            var kernel = new StandardKernel();
            kernel.Load<Module>();

            var formFactory = kernel.Get<IFormFactory>();
            StringReader stringReader = new StringReader(Resources._in);

            Base form = formFactory.Create(stringReader);

            Console.WriteLine(form);
            Console.ReadKey();
        }
    }
}
