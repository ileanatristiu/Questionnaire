using Formular;

namespace FormularFactory
{
    public interface IChoiceQuestionFactory
    {
        IChoiceQuestion CreateChoiceQuestion(string input);
    }
}