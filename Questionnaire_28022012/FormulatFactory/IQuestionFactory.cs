using Formular;

namespace FormulatFactory
{
    public interface IQuestionFactory : IBaseFactory
    {
        Base Create(string[] line);
    }
}