using System.Collections.Generic;

namespace Formular
{
    public abstract class ChoiceQuestion : Question, IChoiceQuestion
    {
        public List<Answer> PossibleAnswers { get; set; }
    }
}
