using System;
using System.Linq;

namespace Formular
{
    public class Base
    {
        public string Name { get; set; }

        public ItemsCollection Items { get; set; }

        public Base()
        {
            Items = new ItemsCollection();
        }

        public override string ToString()
        {
            return Items.Aggregate(string.Empty, (current, item) => string.Concat(current, string.Format("{0}{1}", Environment.NewLine, item.ToString())));
        }
    }
}