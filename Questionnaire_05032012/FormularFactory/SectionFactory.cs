using Formular;

namespace FormularFactory
{
    public class SectionFactory : BaseFactory<Section>, ISectionFactory
    {
        public SectionFactory(IQuestionFactory questionFactory)
        {
            ChildFactory = questionFactory;
        }
    }
}