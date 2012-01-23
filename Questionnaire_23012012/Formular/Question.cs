namespace Formular
{
    public class Question : IQuestion
    {
        public string Text { get; set; }

        public override string ToString()
        {
            return new string(' ', 3);
        }
    }
}
