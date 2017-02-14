/*
Delegates:

A delegate is a type safe function pointer. That is, it holds a reference (Pointer) tp a function.

The signature of the delegate must match the signature of the function, the delegate points to, otherwise you get
a compiler error. This is the reason delegates are called as type safe function pointers.

A delegate is similar to a class. You can create an instance of it, and when you do so, you pass in the function name
as a parameter to the delegate constructor, and it is to this function the delegate will point to.

Tip to remember delegate syntax: Delegates syntax look very much similar to a method with a delegate keyword


 */

using System;

public delegate void HelloFunctionDelegate(string Message);

class Program
{
	public static void Main()
	{
		//	A delegate is a type safe function pointer
		//	pass in a function you want to invoke
		HelloFunctionDelegate del = new HelloFunctionDelegate(Hello);
		del("Hello from Delegate");
	}

	public static void Hello(string strMessage)
	{
		Console.WriteLine(strMessage);
	}
}

