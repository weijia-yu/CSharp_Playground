using System;
namespace Cs_Playground.DesignPattern
{
    public abstract class AlgorithmAsync
    {
        public void FinishOneTask()
        {
            StepOne();

        }

        protected void onStepOneFinish() {
            StepTwo();
        }

        protected void onStepTwoFinish() {
            StepThree();
        }

        protected void onStepThreeFinish() {
            
        }

        public abstract void StepOne();
        public abstract void StepTwo();
        public abstract void StepThree();
    }

    public class AlgorithmAsyncInstance : AlgorithmAsync
    {
        public override void StepOne()
        {
            Console.WriteLine("step1");
            onStepOneFinish();
        }

        public override void StepTwo()
        {
            Console.WriteLine("step2");
            onStepTwoFinish();

        }

        public override void StepThree()
        {
            Console.WriteLine("step3");
            onStepThreeFinish();
        }


    }
}