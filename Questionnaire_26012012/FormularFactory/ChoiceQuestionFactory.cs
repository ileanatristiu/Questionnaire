using Formular;

namespace FormularFactory
{
    public abstract class ChoiceQuestionFactory : IChoiceQuestionFactory
    {
        public abstract IChoiceQuestion CreateChoiceQuestion(string input);
    }
}
