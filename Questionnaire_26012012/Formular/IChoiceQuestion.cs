using System.Collections.Generic;

namespace Formular
{
    public interface IChoiceQuestion : IQuestion
    {
        List<string> PossibleAnswers { get; set; }
    }
}