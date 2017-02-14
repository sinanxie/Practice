/*
Polymorphism

Polymorphism is one of the primary pillars of OOP
Polymorphism allows you to invoke derived class methods through a base class reference during runtime
In the base class the method is declared virtual, and in the derived class we override the same method.
The virtual keyword indecates, the method can be overrideen in any derived class.
 */
using System;

public class Employee
{
	public string FirstName = "FN";
	public string LastName = "LN";

	//	if don't use virtual to override then the base virtual implementation will be available to the 
	//	derived class
	public virtual void PrintFullName()
	{
		Console.WriteLine(FirstName + " " + LastName);
	}
}

public class PartTimeEmployee : Employee
{
	public override void PrintFullName()
	{
		Console.WriteLine(FirstName + " " + LastName + " - Part Time");
	}
}

public class FullTimeEmployee : Employee
{
	public override void PrintFullName()
	{
		Console.WriteLine(FirstName + " " + LastName + " - Full Time");
	}
}

public class TemporaryEmployee : Employee
{
	public override void PrintFullName()
	{
		Console.WriteLine(FirstName + " " + LastName + " - Temporary");
	}
}

public class MethodHiding
{
	public static void Main(){
		Employee[] employees = new Employee[4];

		employees[0] = new Employee();
		employees[1] = new PartTimeEmployee();
		employees[2] = new FullTimeEmployee();
		employees[3] = new TemporaryEmployee();

		foreach(Employee e in employees)
		{
			e.PrintFullName();
		}
	}
}