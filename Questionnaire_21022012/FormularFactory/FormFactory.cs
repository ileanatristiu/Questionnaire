using Formular;

namespace FormularFactory
{
    public class FormFactory : BaseFactory<Form>, IFormFactory
    {
        public override IBaseFactory ChilfFactory { get; set; }

        public FormFactory(IPageFactory pageFactory)
        {
            ChilfFactory = pageFactory;
        }
    }
}