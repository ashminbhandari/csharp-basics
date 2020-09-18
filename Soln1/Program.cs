using System;

namespace Soln1
{
    public class CityBaseClass {
        public virtual void print() {
            Console.WriteLine("I am base.");
        }
    }

    public class CityDerivedClass : CityBaseClass {
        public override void print() {
            Console.WriteLine("I am derived.");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            CityBaseClass cbc = new CityBaseClass();
            CityDerivedClass cdc = new CityDerivedClass();
            cbc.print(); //I am base
            cdc.print(); //I am dreived
            cbc = new CityDerivedClass();
            cbc.print(); //I am derived. If virtual was not used, it would print "I am base"
            //cdc = new CityBaseClass(); Not allowed
        }
    }
}
