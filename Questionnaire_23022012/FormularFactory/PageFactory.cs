using Formular;
using Ninject;

namespace FormularFactory
{
    public class PageFactory : BaseFactory<Page>, IPageFactory
    {
        public override sealed IBaseFactory ChildFactory { get; set; }

        [Inject]
        public PageFactory(ISectionFactory sectionFactory)
        {
            ChildFactory = sectionFactory;
        }
    }
}