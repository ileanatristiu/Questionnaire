using Formular;

namespace FormularFactory
{
    public class PageFactory : BaseFactory<Page>, IPageFactory
    {
        public override IBaseFactory ChilfFactory { get; set; }

        public PageFactory(ISectionFactory sectionFactory)
        {
            ChilfFactory = sectionFactory;
        }

        public PageFactory()
        {
            
        }
    }
}