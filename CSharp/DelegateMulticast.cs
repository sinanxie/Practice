//https://www.youtube.com/watch?v=7uJYp9NIhfQ&index=39&list=PLAC325451207E3105
/*
Multicast Delegates:

A Multicast delegate is a delegate that has references to more than one function. 
When you invoke a multicast delegate, all the functions the delegate is pointing to, are invoked.

There are 2 approaches to create a multicast delegate. Depending on the approach you use
+ or += to register a method with the delegate
- or -= to un_register a method with the delegate

Note: A mulicast delegate, invokes the methods in the invocation list, in the same order in which they are added.

If the delegate has a return type other than void and if the delegate is a multicast delegate, only the value of
the last invoked method will be returned. Along the same lines, if the delegate has an out parameter, the value of
the output parameter, will be the value assigned by the last method.

Common interview question - Where do you use multicast delegates?
Multicast delegate makes implementation of  observer design pattern very simple. Observer pattern is also called as
publish/subscribe pattern

 */

using System;

public delegate int SampleDelegate();
public delegate void SampleDelegate2(out int Integer);

class Program
{
	public static void Main()
	{
		/*
		SampleDelegate del = new SampleDelegate(SampleMethodOne);
		del();
		*/
		

		/*
		SampleDelegate del1, del2, del3, del4;

		del1 = new SampleDelegate(SampleMethodOne);
		del2 = new SampleDelegate(SampleMethodTwo);
		del3 = new SampleDelegate(SampleMethodThree);

		del4 = del1 + del2 + del3 - del2;
		del4();
		*/
	

		SampleDelegate del = new SampleDelegate(SampleMethodOne);
		del += SampleMethodTwo;
		//del += SampleMethodThree;
		//del -= SampleMethodOne;
		int DelegateReturnedValue = del();
		Console.WriteLine("DelegateReturnedValue = {0}", DelegateReturnedValue);



		SampleDelegate2 dell = new SampleDelegate2(SampleMethodOne);
		dell += SampleMethodTwo;

		int DelegateOutputParameterValue = -1;
		dell(out DelegateOutputParameterValue);

		Console.WriteLine("DelegateOutputParameterValue = {0}", DelegateOutputParameterValue);
	}

	public static int SampleMethodOne()
	{
		Console.WriteLine("SampleMethodOne Invoked");
		return 1;
	}
	public static int SampleMethodTwo()
	{
		Console.WriteLine("SampleMethodTwo Invoked");
		return 2;
	}
	public static void SampleMethodThree()
	{
		Console.WriteLine("SampleMethodThree Invoked");
	}

	public static void SampleMethodOne(out int Number)
	{
		Number = 1;
	}
	public static void SampleMethodTwo(out int Number)
	{
		Number = 2;
	}
}



