using Ninject;
using Ninject.Modules;

public class TestModule : NinjectModule {
    public override void Load() {
        Bind<ITesting>().To<Testing>();
        Bind<Test2>().ToSelf().InSingletonScope();
    }
}
