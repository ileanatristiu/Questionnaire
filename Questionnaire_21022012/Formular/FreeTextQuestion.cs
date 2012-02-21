namespace Formular
{
    public class FreeTextQuestion : Question
    {
        public override string ToString()
        {
            return string.Concat(base.ToString(), new string('_', 3));
        }
    }
}