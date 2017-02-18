//	https://www.youtube.com/watch?v=g-LJlrMXZ5k&list=PLAC325451207E3105&index=45
/*
Enums:

Enums are strongly typed constants.

If a program uses set of integral numbers, consider replacing them with enums. 
Otherwise the progrom becomes less
	Readable
	Maintainable

1. Enums are enumerations
2. Enums are strongly typed constants. Hence, an explicit cast is needed to convert from enum type to an integral type 
and vice versa. Also, an enum of one type cannot be implicitly assgined to an enum of another type even though the
underlying value of their members are the same.
3. The default underlying type of an enum is int.
4. The default value for first element is ZERO and gets incremented by 1.
5. It is possible to customize the underlying type and values.
6. Enum keyword(all small letters) is used to create enumerations, where as Enum class, contains static GetValues() and
GetNames() methods which can be used to list Enum underlying type values and Names.
7. Enums are value types

 */

using System;

public class Enums
{
	public static void Main()
	{
		Customer[] customers = new Customer[3];

		customers[0] = new Customer
		{
			Name = "Mark",
			Gender = Gender.Male
		};

		customers[1] = new Customer
		{
			Name = "Mary",
			Gender = Gender.Female
		};

		customers[2] = new Customer
		{
			Name = "Sam",
			Gender = Gender.Unknow
		};

		foreach (Customer customer in customers)
		{
			Console.WriteLine("Name = {0} && Gender = {1}", customer.Name, GetGender(customer.Gender));
		}
	}

	public static string GetGender (Gender gender)
	{
		switch(gender)
		{
			case Gender.Unknow:
				return "Unknow";
			case Gender.Male:
				return "Male";
			case Gender.Female:
				return "Female";
			default:
				return "Invalid data detected";
		}
	}
}

public enum Gender
{
	Unknow,
	Male,
	Female
}

//	0 - Unknow
//	1 - Male
//	2 - Female
public class Customer
{
	public string Name { get; set; }
	public Gender Gender { get; set; }
}


