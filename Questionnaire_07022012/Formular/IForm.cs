using System.Collections.Generic;

namespace Formular
{
    public interface IForm
    {
        string Name { get; set; }

        List<IPage> Pages { get; set; }
    }
}