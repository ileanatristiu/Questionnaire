using Formular;
using Ninject;

namespace FormularFactory
{
    public sealed class SectionFactory : BaseFactory<Section>, ISectionFactory
    {
        [Inject]
        public SectionFactory(IQuestionFactory questionFactory)
        {
            ChildFactory = questionFactory;
        }
    }
}