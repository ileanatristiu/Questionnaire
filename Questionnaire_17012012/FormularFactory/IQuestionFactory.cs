using Formular;

namespace FormularFactory
{
    public interface IQuestionFactory
    {
        IQuestion CreateQuestion(string input);
    }
}