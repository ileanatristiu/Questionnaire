using Formular;

namespace FormularFactory
{
    public class PageFactory : BaseFactory<Page>, IPageFactory
    {
        public override IBaseFactory ChildFactory { get; set; }

        public PageFactory(ISectionFactory sectionFactory)
        {
            ChildFactory = sectionFactory;
        }
    }
}