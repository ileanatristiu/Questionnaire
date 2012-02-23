using Formular;
using Ninject;

namespace FormularFactory
{
    public class FormFactory : BaseFactory<Form>, IFormFactory
    {
        public override sealed IBaseFactory ChildFactory { get; set; }

        [Inject]
        public FormFactory(IPageFactory pageFactory)
        {
            ChildFactory = pageFactory;
        }
    }
}