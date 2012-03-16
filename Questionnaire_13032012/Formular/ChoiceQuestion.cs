using System.Linq;

namespace Formular
{
    public abstract class ChoiceQuestion : Question
    {
        public abstract string Splitter { get; }

        public override string ToString()
        {
            string result = Items.Aggregate(string.Empty, (current, item) => string.Concat(current, Splitter, item.Name));

            return string.Concat(base.ToString(), result, Splitter);
        }
    }
}