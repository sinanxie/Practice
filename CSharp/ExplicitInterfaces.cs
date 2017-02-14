/*
Question: 
A class inherits from 2 interfaces and both the interfaces have the same method name. How should the class implement
the method for both the interfaces?
 */

using System;

interface I1
{
	void InterfaceMethod();
}

interface I2
{
	void InterfaceMethod();
}

public class Program : I1, I2
{
	//	cannot add public
	//	Access modifiers are not allowed
	void I1.InterfaceMethod()
	{
		Console.WriteLine("I1 Interface Method");
	}

	void I2.InterfaceMethod()
	{
		Console.WriteLine("I2 Interface Method");
	}

	public static void Main()
	{
		Program P = new Program();
		//	cannot call 'P.InterfaceMethod()'
		//	can only accessed thru the interface reference variable
		((I1)P).InterfaceMethod();
		((I2)P).InterfaceMethod();

		I1 i1 = new Program();
		I2 i2 = new Program();
		i1.InterfaceMethod();
		i2.InterfaceMethod();
	}
}