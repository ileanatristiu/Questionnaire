using System.Collections.Generic;

namespace Formular
{
    public interface IChoiceQuestion
    {
        List<Answer> PossibleAnswers { get; set; }
    }
}