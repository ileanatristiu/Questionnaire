using System;
using System.IO;
using Formular;

namespace FormularFactory
{
    public abstract class BaseFactory<T> : IBaseFactory
        where T : Base, new()
    {
        public abstract IBaseFactory ChilfFactory { get; set; }

        public virtual Base Create(StringReader input)
        {
            string[] line = input.ReadLine().Split();
            var item = new T { Name = line[0] };
            for (int i = 0; i < Convert.ToInt16(line[1]); i++)
            {
                item.Items.Add(ChilfFactory.Create(input));
            }

            return item;
        }
    }

    public interface IBaseFactory
    {
        Base Create(StringReader input);
    }
}