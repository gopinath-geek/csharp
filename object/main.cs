using System;

class Program{
	static void Main(string[] args){
		object input;
		input = 75;
		Console.WriteLine(input.GetType());
		input = 75.235;
		Console.WriteLine(input.GetType());
		input = "Some text";
		Console.WriteLine(input.GetType());
		input = 'C';
		Console.WriteLine(input.GetType());
		input = true;
		Console.WriteLine(input.GetType());
	
	}
}