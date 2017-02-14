//	https://www.codeproject.com/Articles/816448/Virtual-vs-Override-vs-New-Keyword-in-Csharp
/*
Virtual:
	Virtual keyword is used for generating a virtual path for its derived classes on implementing method overriding. 
	Virtual keyword is used within a set with override keyword.

Override:
	Override keyword is used in the derived class of the base class in order to override the base class method. 
	Override keyword is used with virtual keyword

New:
	New keyword is also used in polymorphism concept, but in the case of method overloading So what does overloading means, 
	in simple words we can say procedure of hiding your base class through your derived class.


 */


using System;

namespace VirtualOverride
{
    class A
    {
        public virtual void show()
        {
            Console.WriteLine("Hello: Base Class!");
            Console.ReadLine();
        }
    }

    class B : A
    {
        public override void show()
        {
            Console.WriteLine("Hello: Derived Class!");
            Console.ReadLine();
        }
    }

    class C : B
    {
        public new void show()
        {
            Console.WriteLine("Am Here!");
            Console.ReadLine();
        }
    }

    class Polymorphism
    {
        public static void Main()
        {
            A a1 = new A();
            a1.show();
            B b1 = new B();
            b1.show();
            C c1 = new C();
            c1.show();
            A a2 = new B();
            a2.show();
            A a3 = new C();
            a3.show();
            B b3 = new C();
            b3.show();
        }
    }
}