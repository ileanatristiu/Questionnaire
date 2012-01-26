using Formular;

namespace FormularFactory
{
    public class MultipleChoiceQuestionFatory : ChoiceQuestionFactory
    {
        public override IChoiceQuestion CreateChoiceQuestion(string input)
        {
            return new MultipleChoiceQuestion();
        }
    }
}
