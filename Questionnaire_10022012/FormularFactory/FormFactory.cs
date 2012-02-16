using Formular;

namespace FormularFactory
{
    public class FormFactory : BaseFactory<Form>, IFormFactory
    {
        public override sealed IBaseFactory ChildFactory { get; set; }

        public FormFactory(IPageFactory pageFactory)
        {
            ChildFactory = pageFactory;
        }
    }
}