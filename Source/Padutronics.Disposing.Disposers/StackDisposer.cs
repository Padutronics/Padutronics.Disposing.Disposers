using System;
using System.Collections.Generic;

namespace Padutronics.Disposing.Disposers;

public sealed class StackDisposer : DisposableObject, IDisposer
{
    private readonly Stack<IDisposable> instances = new();

    public void AddInstanceForDisposal(IDisposable instance)
    {
        instances.Push(instance);
    }

    protected override void Dispose(bool isDisposing)
    {
        if (isDisposing)
        {
            while (instances.TryPop(out IDisposable? instance))
            {
                instance.Dispose();
            }
        }
    }
}