using System;
 
class Program{
	static void Main(string[] args){
		int count = 0;
		
		for(int i=0; i<args[0].Length; i++ )
			if( int.Parse(args[0][i].ToString()) % 4 == 0)
				count++;
		
		Console.WriteLine("Thre are ({0}) Multiple of 4's in {1}", count, args[0]);
	}
}