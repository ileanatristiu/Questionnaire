using Formular;

namespace FormularFactory
{
    public interface IChoiceQuestionFactory
    {
        ChoiceQuestion CreateChoiceQuestion(string input);
    }
}