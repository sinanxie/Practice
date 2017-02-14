//	https://www.youtube.com/watch?v=iGR425gMKeA&list=PLAC325451207E3105&index=27

using System;

public class Student
{
	private int _id;
	private string _name;
	private int _passMark = 35;
	private string _city;
	private string _email;

	public string Email
	{
		get
		{
			return this._email;
		}
		set
		{
			this._email = value;
		}
	}

	//	It there is no additional logic in the property accessors, then we can make use of auto-implemented properties
	public string City { get; set; }

	public int PassMark
	{
		get
		{
			return this._passMark;
		}
	}

	public int Id
	{
		set
		{
			if (value <= 0) 
			{
				throw new Exception("Student Id cannot be negative");
			}
			this._id = value;
		}
		get
		{
			return this._id;
		}
	}

	public string Name
	{
		set
		{
			if (string.IsNullOrEmpty(value))
			{
				throw new Exception("Name cannot be null or empty");
			}
			this._name = value;
		}
		get
		{
			return string.IsNullOrEmpty(this._name) ? "No Name" : this._name;
		}
	}
}

public class Program
{
	public static void Main()
	{
		Student C1 = new Student();
		C1.Id = 191;
		C1.Name = "Mark";

		Console.WriteLine("Student Id = {0}", C1.Id);
		Console.WriteLine("Student Name = {0}", C1.Name);
		Console.WriteLine("PassMark = {0}", C1.PassMark);
	}
}



