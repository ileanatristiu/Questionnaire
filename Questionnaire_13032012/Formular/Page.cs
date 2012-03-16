namespace Formular
{
    public class Page : Base
    {
        public override string ToString()
        {
            return string.Concat(new string(' ', 1), Name, base.ToString());
        }
    }
}