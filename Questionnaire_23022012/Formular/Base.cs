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
    }
}