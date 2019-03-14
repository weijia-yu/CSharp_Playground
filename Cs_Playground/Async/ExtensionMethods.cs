using System;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace Cs_Playground.Async
{
    public static class FuncExtensions
    {
        public static TaskAwaiter<TResult> GetAwaiter<TResult>(this Func<TResult> function)
        {
            Task<TResult> task = new Task<TResult>(function);
            task.Start();
            return task.GetAwaiter(); // Returns a TaskAwaiter<TResult>.
        }
    }
}
