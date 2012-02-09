﻿using Ninject.Modules;

namespace FormularFactory
{
    public class Module : NinjectModule
    {
        public override void Load()
        {
            Bind<IFormFactory>().To<FormFactory>();
            Bind<IPageFactory>().To<PageFactory>();
            Bind<ISectionFactory>().To<SectionFactory>();
            Bind<IQuestionFactory>().To<QuestionFactory>();
        }
    }
}