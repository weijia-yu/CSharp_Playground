using System;
using System.Collections.Generic;
namespace Cs_Playground.Inheritance
{
    public class TestBaseClass {

        public void Test()
        {
            //List<BaseClass> list = new List<BaseClass>();
            //list.Add(new DerivedClassA);
            BaseClass a = new DerivedClassA();
            BaseClass b = new DerivedClassB();

            Console.WriteLine(a.GetType());
            Console.WriteLine(b.GetType());

            Console.WriteLine( (a as DerivedClassA).AValue);
            Console.WriteLine(b.GetType());

        }
    }

    public class BaseClass
    {
        public BaseClass()
        {
            
        }
    }

    public class DerivedClassA : BaseClass
    {
        public int AValue;
        public DerivedClassA() {
            
        }
    }

    public class DerivedClassB : BaseClass
    {
        public int BValue;
        public DerivedClassB()
        {

        }
    }
}
