using System;

class Factorial{
	static void Main(string[] args){
		Factorial F = new Factorial();
		Console.WriteLine("Factorial of 6 is : {0} ", F.fact(5));
	}
	
	public int fact(int number){
		int result;
		if(number == 1){
			return 1;
		}
		else{
			result = fact(number - 1) * number;
			return result;
		}
	}
}