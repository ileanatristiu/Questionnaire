using System.Collections.Generic;

namespace Formular
{
    public abstract class ChoiceQuestion : IChoiceQuestion
    {
        public string Text { get; set; }

        public List<string> PossibleAnswers { get; set; }

        public ChoiceQuestion()
        {
            PossibleAnswers = new List<string>();
        }
    }
}
