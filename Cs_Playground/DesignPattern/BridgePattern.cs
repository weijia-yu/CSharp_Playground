using System;
namespace Cs_Playground.DesignPattern
{
    public interface Shift {
        String GetCarType();
    }

    public class ManualShift : Shift
    {
        public String GetCarType()
        {
            return "manual";
        }
    }

    public class AutomaticShift : Shift
    {
        public String GetCarType()
        {
            return "automatic";
        }
    }

    public abstract class Car
    {
        protected Shift _shift;
        public abstract void Print();
    }

    public class Jeep : Car {
        public Jeep(Shift shift) {
            _shift = shift;
        }

        public override void Print() {
            Console.Write("jeep " + _shift.GetCarType());
        }
    }

    public class BMW : Car
    {
        public BMW(Shift shift)
        {
            _shift = shift;
        }

        public override void Print()
        {
            Console.Write("BMW " + _shift.GetCarType());
        }
    }
}
