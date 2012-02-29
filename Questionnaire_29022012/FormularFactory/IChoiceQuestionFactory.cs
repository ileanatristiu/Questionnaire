using Formular;

namespace FormularFactory
{
    public interface IChoiceQuestionFactory
    {
        ChoiceQuestion Create(string line);
    }
}