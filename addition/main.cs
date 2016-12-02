using System;

class Program{
	static void Main(string[] args){
		int i = Int32.Parse(args[0]);
		int[] input = new int[i];
		int answer = 0;
		
		if(i <= 10 && i >= 1){
			for(int j = 0; j < i; j++){
				int val = Int32.Parse(Console.ReadLine());
				if( val <= 100 && val >= 0 )
					input[j] = val;
				else
					input[j] = 100;
			}
			
			for(int j = 0; j < i; j++)
				answer = input[j] + answer;
			
			Console.WriteLine("Total of {0} values is {1}", i, answer);
		}else{
			Console.WriteLine("Cannot Accept value larger than ten");
		}
	}
}