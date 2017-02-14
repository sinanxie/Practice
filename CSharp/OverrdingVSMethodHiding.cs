/*
method Overriding

a base class reference variable pointing to a child class object,
will invoke the overridden method in the CHILD class


method Hidding

a base class reference variable pointing to a child class object,
will invoke the hidden method in the BASE class
 */

using System;

public class BaseClass
{
	public virtual void Print()
	{
		Console.WriteLine("I am a Base Class Print Method");
	}
}

public class DerivedClass : BaseClass
{
	//public override void Print()
	public new void Print()
	{
		Console.WriteLine("I am a Derived Class Print Method");
	}
}

public class Program
{
	public static void Main()
	{
		BaseClass B = new DerivedClass();
		B.Print();
	}
}