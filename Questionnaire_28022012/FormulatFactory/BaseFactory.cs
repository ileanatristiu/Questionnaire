﻿using System.IO;
using Formular;

namespace FormulatFactory
{
    public abstract class BaseFactory<T> : IBaseFactory
        where T : Base
    {
        public IBaseFactory ChildFactory { get; set; }

        public virtual Base Create(StringReader input)
        {
            throw new System.NotImplementedException();
        }
    }
}