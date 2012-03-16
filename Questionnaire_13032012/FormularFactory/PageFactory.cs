using Formular;
using Ninject;

namespace FormularFactory
{
    public class PageFactory : BaseFactory<Page>, IPageFactory
    {
        [Inject]
        public PageFactory(ISectionFactory sectionFactory)
        {
            ChildFactory = sectionFactory;
        }
    }
}