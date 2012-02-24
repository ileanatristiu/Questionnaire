namespace Formular
{
    public class ChoiceQuestion : Question
    {
        public override string ToString()
        {
            string s = string.Empty;
            foreach (var item in Items)
            {
                s = string.Concat(s, "|", item.Name, "|");
            }

            return string.Concat(base.ToString(), s);
        }
    }
}