﻿using System;
using System.IO;
using Formular;

namespace FormularFactory
{
    public abstract class BaseFactory<T> : IBaseFactory
        where T : Base, new()
    {
        public abstract IBaseFactory ChildFactory
        {
            get;
            set;
        }

        public Base Create(StringReader stringReader)
        {
            return CreateCore(stringReader);
        }

        public T CreateCore(StringReader input)
        {
            string[] line = input.ReadLine().Split();
            var item = new T
                           {
                               Name = line[0]
                           };
            for (int i = 0; i < Convert.ToInt16(line[1]); i++)
            {
                item.Items.Add(ChildFactory.Create(input));
            }

            return item;
        }
    }

    public interface IBaseFactory
    {
        Base Create(StringReader stringReader);
    }
}