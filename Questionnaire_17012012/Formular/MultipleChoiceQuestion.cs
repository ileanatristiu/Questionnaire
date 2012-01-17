using System.Collections.Generic;

namespace Formular
{
    public class MultipleChoiceQuestion : ChoiceQuestion
    {
        public List<Answer> QuestionAnswers { get; set; }
    }
}
