namespace Formular
{
    public class Page : Base
    {
        public override string ToString()
        {
            return string.Concat(string.Concat(' ', Name), base.ToString());
        }
    }
}