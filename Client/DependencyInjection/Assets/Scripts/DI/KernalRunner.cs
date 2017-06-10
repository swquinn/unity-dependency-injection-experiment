using UnityEngine;
using System.Collections;
using Ninject;

public class KernalRunner {

    public KernalRunner() {
        IKernel kernel = new StandardKernel(new TestModule());
        ITesting testing = kernel.Get<ITesting>();
        testing.Test();
    }
}
