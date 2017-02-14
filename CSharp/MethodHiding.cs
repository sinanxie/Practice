/*
Inheritance Concepts

Use the new keyword to hide a base class member. You will get a compiler warning, if you miss the new keyword.

Different ways to invoke a hidden base class member from derived class
1. Use base keyword
2. Cast child type to parent type and invoke the hidden member
3. ParentClass PC = new ChildClass()
   PC.HiddenMethod();
 */

using System;

public class Employee
{
	public string FirstName;
	public string LastName;

	public void PrintFullName()
	{
		Console.WriteLine(FirstName + " " + LastName);
	}
}

public class PartTimeEmployee : Employee
{
	/*
	New:
	New keyword is also used in polymorphism concept, but in the case of method overloading So what does overloading means, 
	in simple words we can say procedure of hiding your base class through your derived class.
	 */
	public new void PrintFullName()
	{
		//	base.PrintFullName();	//	base refer to hidden base class
		Console.WriteLine(FirstName + " " + LastName + " - Contractor");
	}
}

public class FullTimeEmployee : Employee
{

}

public class MethodHiding
{
	public static void Main(){
		FullTimeEmployee FTE = new FullTimeEmployee();
		FTE.FirstName = "FullTime";
		FTE.LastName = "Employee";
		FTE.PrintFullName();

		PartTimeEmployee PTE = new PartTimeEmployee();
		PTE.FirstName = "PartTime";
		PTE.LastName = "Employee";
		((Employee)PTE).PrintFullName();
		//PTE.PrintFullName();
		
		Employee PTE2 = new PartTimeEmployee();
		PTE2.FirstName = "PartTime";
		PTE2.LastName = "Employee";
		PTE2.PrintFullName();	//	Call the hidden method of base class
	}
}