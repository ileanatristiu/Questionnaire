using System.Collections.Generic;

namespace Formular
{
    public interface IChoiceQuestion : IQuestion
    {
        List<PossibleAnswer> PossibleAnswers { get; set; }
    }
}