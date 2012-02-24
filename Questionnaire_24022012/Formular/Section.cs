namespace Formular
{
    public class Section : Base
    {
        public override string ToString()
        {
            return string.Concat(new string(' ', 2), Name, base.ToString());
        }
    }
}