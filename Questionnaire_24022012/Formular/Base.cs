using System;
using System.Linq;

namespace Formular
{
    public abstract class Base
    {
        public string Name { get; set; }

        public ItemsCollection Items { get; set; }

        protected Base()
        {
            Items = new ItemsCollection();
        }

        public override string ToString()
        {
            return Items.Aggregate(string.Empty, (current, item) => string.Concat(current, string.Format("{0}{1}", Environment.NewLine, item.ToString()))); ;
        }
    }
}