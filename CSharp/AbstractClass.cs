/*
Abstract Class:

An abstract class is imcomplete and hence cannot be instantiated

An abstract class can only be used as base class

An abstract class cannot be sealed

AN abstract class may contain abstract members(methods, properties, indexers, and events), but not mandatory

A non-abstract class derived from an abstract class must provide implementations for all inherited abstract members

If a class inherits an abstract class, there are 2 options available for that class:
Option 1: Provide implementations for all the abstract memebers inherited from the base abstract class.
Option 2: If the class does not wish to provide implementation for all the abstract memebers inherited from the abstract class,
then the class has to be marked as abstract
 */

using System;

public abstract class Customer
{
	public abstract void Print();
}

public class Program : Customer
{
	//	override keyword!!!
	public override void Print()
	{
		Console.WriteLine("Print Method");
	}

	public static void Main()
	{
		Customer C = new Program();
		C.Print();
	}
}