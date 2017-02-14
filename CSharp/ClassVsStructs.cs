//	https://www.youtube.com/watch?v=AGNW0jH1sn0&list=PLAC325451207E3105&index=29
/*
Difference between classes and structs in C#

A struct is a value type where as a class is a reference type.

Structs are stored on stack, where as classes are stored on the heap.

Value types hold their value in memory where they are declared, 
but reference types hold a reference to an object in memory.

Value types are destroyed immediately after the scoop is lost, where as for reference types only the 
reference variable is destroyed after the scope is lost. The object is later destropyed by garbage collector

When you copy a struct into another struct, a new copy of that struct gets created and modifications on one struct
will not affect the values contained by the other struct.

When you copy a class into another class, we only get a copy of the referrence variable. Both the reference variables
point to the same object on the heap. So, operations on one variable will affect the values contained by the other
reference variable.



Structs can't have destructors, but classes can have destructors.

Structs cannot have explicit parameter less constructor where as a class can.

Struct can't inherit from another class where as a class can. Both structs and classes can inherit from an interface.

Examples of structs in the .Net Framework - int (System.Int32), double(System.Double) etc


Note:
1. A class or a struct cannot inherit from another struct. Struct are sealed types.
2. How do you prevent a class from being inherited? Or what is the significance of sealed keyword?
	if you mark a class as sealed, you can not use that class for a base class for any other class
	prevent classes from being inherited
 */

using System;

public class Customer
{
	public int ID { get; set; }
	public string Name { get; set; }

	//	cannot exist in struct
	public Customer()
	{

	}

	//	cannot exist in struct
	~Customer()
	{

	}
}

public class Program
{
	public static void Main()
	{
		//	System.Int32 i = 0;
		int i = 10;		//	int is a struct System.Int32    Represents a 32-bit signed integer
		int j = i;		
		j = j + 1;
		Console.WriteLine("i = {0} && j = {1}", i, j);

		Customer C1 = new Customer();
		C1.ID = 101;
		C1.Name = "Mark";

		Customer C2 = C1;
		C2.Name = "Mary";
		Console.WriteLine("C1.Name = {0} && C2.Name = {1}", C1.Name, C2.Name);
	}
}




