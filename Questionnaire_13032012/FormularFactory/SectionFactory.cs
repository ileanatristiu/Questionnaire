using Formular;
using Ninject;

namespace FormularFactory
{
    public class SectionFactory : BaseFactory<Section>, ISectionFactory
    {
        [Inject]
        public SectionFactory(IQuestionFactory questionFactory)
        {
            ChildFactory = questionFactory;
        }
    }
}