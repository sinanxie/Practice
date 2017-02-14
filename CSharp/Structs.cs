//	https://www.youtube.com/watch?v=M8DZqt3tCr4&index=28&list=PLAC325451207E3105
/*
Structs

Just like classes structs can have
1. private fields
2. public properties
3. constructors
4. methods

 */

using System;

public struct Customer
{
	private int _id;
	private string _name;

	public int ID
	{
		get { return this._id; }
		set { this._id = value; }
	}

	public string Name
	{
		get { return this._name; }
		set { this._name = value; }
	}

	//	constructor
	public Customer(int Id, string Name)
	{
		this._id = Id;
		this._name = Name;
	}

	public void PrintDetails()
	{
		Console.WriteLine("Id = {0} && Name = {1}", this._id, this._name);
	}
}

public class Program
{
	public static void Main()
	{
		Customer C1 = new Customer(101, "Mark");
		C1.PrintDetails();

		Customer C2 = new Customer();
		C2.PrintDetails();
		C2.ID = 102;
		C2.Name = "John";
		C2.PrintDetails();

		//	object initializer syntax
		//	introduced in C# 3.0 can be used to initialize either a struct or a class
		Customer C3 = new Customer
		{
			ID = 103,
			Name = "Rob"
		};
		C3.PrintDetails();
	}
}




