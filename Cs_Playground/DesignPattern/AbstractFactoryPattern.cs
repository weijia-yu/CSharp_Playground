using System;

namespace Cs_Playground.DesignPattern
{
    public interface ICar {
        void GetCarInfo();
    }

    public class ModelX : ICar {
        public void GetCarInfo() {
            Console.WriteLine("Model x");
        }
    }

    public class ModelY: ICar {
        public void GetCarInfo() {
            Console.WriteLine("Model y");
        }
    }

    //factory
    public abstract class Factory {
        public abstract ICar CreateCar();
    }

    public class ModelXFactory : Factory {
        public override ICar CreateCar() {
            return new ModelX();
        }
    }

    public class ModelYFactory : Factory
    {
        public override ICar CreateCar()
        {
            return new ModelY();
        }
    }
}