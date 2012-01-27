using Formular;

namespace FormularFactory
{
    public interface IQuestionFacrory
    {
        IQuestion CreateQuestion(string input);
    }
}