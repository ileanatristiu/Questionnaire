using Formular;
using Ninject;

namespace FormularFactory
{
    public class FormFactory : BaseFactory<Form>, IFormFactory
    {
        [Inject]
        public FormFactory(IPageFactory pageFactory)
        {
            ChildFactory = pageFactory;
        }
    }
}