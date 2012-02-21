using Formular;

namespace FormularFactory
{
    public class SectionFactory : BaseFactory<Section>, ISectionFactory
    {
        public override sealed IBaseFactory ChilfFactory { get; set; }

        public SectionFactory(IQuestionFactory questionFactory)
        {
            ChilfFactory = questionFactory;
        }
    }
}