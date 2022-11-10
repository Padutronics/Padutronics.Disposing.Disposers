using System;

namespace Padutronics.Disposing.Disposers;

public interface IDisposer : IDisposable
{
    void AddInstanceForDisposal(IDisposable instance);
}