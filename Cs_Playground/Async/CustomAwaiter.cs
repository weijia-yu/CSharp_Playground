using System;
using System.Threading.Tasks;

namespace Cs_Playground.Async
{
    public struct FuncAwaiter<TResult> : IAwaiter<TResult>
    {
        private readonly Task<TResult> task;

        public FuncAwaiter(Func<TResult> function)
        {
            this.task = new Task<TResult>(function);
            this.task.Start();
        }

        bool IAwaiter<TResult>.IsCompleted
        {
            get
            {
                return this.task.IsCompleted;
            }
        }

        public void OnCompleted(Action continuation)
        {
            new Task(continuation).Start();
        }

        TResult IAwaiter<TResult>.GetResult()
        {
            return this.task.Result;
        }

    }

}
