using Formular;

namespace FormularFactory
{
    public class FormFactory : BaseFactory<Form>, IFormFactory
    {
        public override IBaseFactory ChildFactory { get; set; }

        public FormFactory(IPageFactory pageFactory)
        {
            ChildFactory = pageFactory;
        }
    }

    public interface IFormFactory : IBaseFactory
    {
    }
}