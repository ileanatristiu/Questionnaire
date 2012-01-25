using System.Collections.Generic;

namespace Formular
{
    public abstract class ChoiceQuestion : IChoiceQuestion
    {
        public string Text { get; set; }

        public List<PossibleAnswer> PossibleAnswers { get; set; }
    }
}
