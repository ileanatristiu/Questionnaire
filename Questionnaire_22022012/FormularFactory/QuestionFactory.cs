using Formular;

namespace FormularFactory
{
    public class QuestionFactory : BaseFactory<Question>, IQuestionFactory
    {
        public override IBaseFactory ChildFactory { get; set; }

        public override Base Create(System.IO.StringReader input)
        {
            input.ReadLine();
            return new FreeTextQuestion();
        }
    }
}