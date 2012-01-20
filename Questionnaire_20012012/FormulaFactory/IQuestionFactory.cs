using Formular;

namespace FormulaFactory
{
    public interface IQuestionFactory
    {
        IQuestion CreateQuestion(string input);
    }
}