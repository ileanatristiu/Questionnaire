namespace Formular
{
    public class Form : Base
    {
        public override string ToString()
        {
            return string.Concat(Name, base.ToString());
        }
    }
}