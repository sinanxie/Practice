/*
Differences between Abstract Class & interfaces:

Abstract classes can have implementations for some of its memebers(Methods),
but the interface can't have implementations for any of its memebers

Interfaces cannot have fields where as an abstract class can have fields

An interface can inherit from another interface only and cannot inherit from an abstract class,
where as an abstract class can inherit from another abstract class or another interface.

A class can inherit from multiple interfaces at ther same time,
where as a class cannot inherit from multiple classes at the same time.

Abstract class memebers can have access modifiers, private by default
where as interface members cannot have access modifiers.

 */

using System;

public abstract class Customer
{
	int ID;
	public void Print()
	{
		Console.WriteLine("Print");
	}
}

public interface ICustomer
{
	void Print();
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