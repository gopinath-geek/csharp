using System;

class Program{
	static void Main(string[] args){
		int age = Int32.Parse(args[0]);
		string name = args[1];
		string gender = args[2];
		
		Console.WriteLine("{0} is {1} years old {2}", name, age, gender);
		Console.ReadKey();
	}
}