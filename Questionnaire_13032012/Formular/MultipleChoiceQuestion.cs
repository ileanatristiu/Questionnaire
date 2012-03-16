namespace Formular
{
    public class MultipleChoiceQuestion : ChoiceQuestion
    {
        public override string Splitter
        {
            get { return "||"; }
        }
    }
}