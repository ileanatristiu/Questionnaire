using Formular;

namespace FormularFactory
{
    public class SectionFactory : BaseFactory<Section>, ISectionFactory
    {
        public override sealed IBaseFactory ChildFactory { get; set; }

        public SectionFactory(IQuestionFactory questionFactory)
        {
            ChildFactory = questionFactory;
        }
    }
}