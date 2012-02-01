using FormularFactory;
using Ninject;

namespace Shell
{
    class Program
    {
        static void Main(string[] args)
        {
            IKernel kernel = new StandardKernel();
            kernel.Load<ModuleClass>();

        }
    }
}
