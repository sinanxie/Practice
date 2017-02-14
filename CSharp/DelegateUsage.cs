/*
Delegates:

A delegate is a type safe function pointer. That is, it holds a reference (Pointer) tp a function.

The signature of the delegate must match the signature of the function, the delegate points to, otherwise you get
a compiler error. This is the reason delegates are called as type safe function pointers.

A delegate is similar to a class. You can create an instance of it, and when you do so, you pass in the function name
as a parameter to the delegate constructor, and it is to this function the delegate will point to.

Tip to remember delegate syntax: Delegates syntax look very much similar to a method with a delegate keyword



Delegate Advance:

Want to reuse the code, want to plug in their logic without modify the code
don't want to hard code your logic

decouple your logic

 */

using System;
using System.Collections.Generic;

class Program
{
	public static void Main()
	{
		List<Employee> empList = new List<Employee>();

		empList.Add(new Employee(){ ID = 101, Name = "Mary", Salary = 5000, Experience = 5});
		empList.Add(new Employee(){ ID = 101, Name = "Mike", Salary = 4000, Experience = 4});
		empList.Add(new Employee(){ ID = 101, Name = "John", Salary = 6000, Experience = 6});
		empList.Add(new Employee(){ ID = 101, Name = "Todd", Salary = 3000, Experience = 3});

		IsPromotable isPromotable = new IsPromotable(Promote);

		Employee.PromoteEmployee(empList, isPromotable);

		//	Lambda expression	//	behind the scene is the same, using delegate
		Employee.PromoteEmployee(empList, emp => emp.Experience >= 5);		
	}

	public static bool Promote(Employee emp)
	{
		if (emp.Experience >= 5)
		{
			return true;
		} 
		else
		{
			return false;
		}
	}
}

delegate bool IsPromotable(Employee empl);

class Employee
{
	public int ID { get; set; }
	public string Name { get; set; }
	public int Salary { get; set; }
	public int Experience { get; set; }

	public static void PromoteEmployee(List<Employee> employeeList, IsPromotable IsEligibleToPromote)
	{
		foreach (Employee employee in employeeList)
		{
			if (IsEligibleToPromote(employee)) 
			{
				Console.WriteLine(employee.Name + " promoted");
			}
		}
	}
}




