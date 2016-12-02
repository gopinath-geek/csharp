/* using System;

class Module{
	
	public unsafe string *sum(string *first, string *second){
		return *first + *second;
	}
}

class Program{
	static unsafe void Main(string[] args){
		Module obj = new Module();
		Console.WriteLine(obj.sum(&args[0], &args[1]));
	}
} */

using System;

class Module{
	public unsafe void Call(){
		Console.WriteLine("Enter two values");
		int first = Int32.Parse(Console.ReadLine());
		int second = Int32.Parse(Console.ReadLine());
		
		int *result = Sum(&first, &second);
		Console.WriteLine("Sum of {0} and {1} is {2}", first, second, *result);
	}
	public unsafe int* Sum(int *first, int *second){
		int res;
		res = *first + *second;
		return &res;
	}
}

class Program{
	static void Main(){
		Module obj = new Module();
		obj.Call();
	}
}
