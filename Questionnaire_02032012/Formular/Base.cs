namespace Formular
{
    public class Base
    {
        public string Name { get; set; }

        public ItemCollection Items { get; set; }

        public Base()
        {
            Items = new ItemCollection();
        }
    }
}