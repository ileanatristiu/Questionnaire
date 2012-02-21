using Formular;

namespace FormularFactory
{
    public class QuestionFactory : BaseFactory<Question>, IQuestionFactory
    {
        public override IBaseFactory ChilfFactory { get; set; }

        public override Base Create(System.IO.StringReader input)
        {
            return new FreeTextQuestion();
        }
    }
}