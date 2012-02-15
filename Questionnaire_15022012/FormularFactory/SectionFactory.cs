using System;
using System.IO;
using Formular;

namespace FormularFactory
{
    public class SectionFactory : BaseFactory<Section>, ISectionFactory
    {
        public override sealed IBaseFactory ChildFactory { get; set; }

        public IQuestionFactory QuestionFactory { get; set; }

        public SectionFactory(IQuestionFactory questionFactory)
        {
            QuestionFactory = questionFactory;
        }
    }
}