using Formular;

namespace FormularFactory
{
    public class ChoiceQuestionFactory : BaseFactory<ChoiceQuestion>, IChoiceQuestionFactory
    {
        public override Base Create(System.IO.StringReader input)
        {
            string[] line = input.ReadLine().Split();
            ChoiceQuestion question = null;

            return base.Create(input);
        }
    }
}