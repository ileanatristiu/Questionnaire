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
    }
}