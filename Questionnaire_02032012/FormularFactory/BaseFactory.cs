using System.IO;
using Formular;

namespace FormularFactory
{
    public abstract class BaseFactory<T> : IBaseFactory
        where T : Base, new()
    {
        public Base Create(StringReader input)
        {
            string[] line = input.ReadLine().Split();
            var item = new T{Name = line[0]};

            return item;
        }
    }
}