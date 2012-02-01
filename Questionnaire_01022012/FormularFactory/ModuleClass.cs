using Ninject.Modules;

namespace FormularFactory
{
    public class ModuleClass : NinjectModule
    {
        public override void Load()
        {
            Bind<ISectionFactory>().To<SectionFactory>();
            Bind<IQuestionFactory>().To<QuestionFactory>();
        }
    }
}
