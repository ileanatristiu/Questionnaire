using System;
using Formular;

namespace FormularFactory
{
    public class PageFactory : BaseFactory<Page>, IPageFactory
    {
        public override IBaseFactory ChildFactory
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    }
}