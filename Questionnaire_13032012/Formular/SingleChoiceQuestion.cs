namespace Formular
{
    public class SingleChoiceQuestion : ChoiceQuestion
    {
        public override string Splitter
        {
            get { return "|"; }
        }
    }
}