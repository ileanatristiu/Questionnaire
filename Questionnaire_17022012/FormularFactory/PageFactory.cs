using Formular;

namespace FormularFactory
{
    public class PageFactory : BaseFactory<Page>
    {
        public override sealed IBaseFactory ChildFactory { get; set; }

        public PageFactory(ISectionFactory sectionFactory)
        {
            ChildFactory = sectionFactory as IBaseFactory;
        }
    }
}