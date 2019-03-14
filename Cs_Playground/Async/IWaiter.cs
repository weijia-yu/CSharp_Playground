using System;
using System.Runtime.CompilerServices;

namespace Cs_Playground.Async
{
    public interface IAwaitable<out TResult>
    {
        IAwaiter<TResult> GetAwaiter();
    }

    public interface IAwaiter<out TResult> : INotifyCompletion // or ICriticalNotifyCompletion
    {
        bool IsCompleted { get; }

        TResult GetResult();
    }


    public struct FuncAwaiter<TResult> : IAwaiter<TResult>
    {

    }
}
