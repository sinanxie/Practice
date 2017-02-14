/*
Interfaces:

interface keyword. Just like classes interfaces also contains properties, methods, delegates or events, 
but only declarations and no implementations.

** It is a compile time error to provide implementations for any interface memeber.

Interface memebers are public by default, and they don't allow explicit access modifiers.

** Interfaces connot contain fields

If a class or a struct inherits from an interface, it must provide implementation for all interface memebers. 
Otherwise, we get a compiler error.

** A class or a struct can inherit from more than one interface at the same time, 
but where as, a class cannot inherit from more than one class at the same time.

Interfaces can inherit from other interfaces. A class that inherits this interface must provide implementation 
for all interface memebers in the entire interface inheritance chain.

** We cannot create an instanca of an interface, but an interface reference variable can point to a derived class object.

 */


using System;

//	naming prefix with I, common naming convention
interface ICustomer1
{	
	//	int ID;		//	cannot contain field
	//	public by default, and you cannot have an explicit access modifier, even it is public
	void Print1();
}

interface ICustomer2 : ICustomer1
{
	void Print2();
}

public class Customer : ICustomer2
{
	public void Print1()
	{
		Console.WriteLine("Print1");
	}
	public void Print2()
	{
		Console.WriteLine("Print2");	
	}
}

public class Program
{
	public static void Main()
	{
		Customer C1 = new Customer();
		C1.Print1();
		C1.Print2();

		ICustomer1 Cust = new Customer();
		Cust.Print1();
		//	Cust.Print2();	//	error
	}
}





