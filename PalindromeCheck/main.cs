using System; 
//using System.Numerics;
class MyClass {
    static void Main(string[] args) {
        /*
         * Read input from stdin and provide input before running
        var line1 = System.Console.ReadLine().Trim();
        var N = Int32.Parse(line1);
        for (var i = 0; i < N; i++) {
            System.Console.WriteLine("hello world");
        }
        */
        
        int T;
        T = int.Parse(Console.ReadLine());
        string[] input = new string[100000];
        string reversed;
        for(int i=0; i<T; i++)
        	input[i] = Console.ReadLine();
		
		for(int i=0; i<T; i++)
		{
			reversed = ReverseInput(input[i]);
			
        	if(reversed == input[i])
        		Console.WriteLine("{0} {1}", "YES", OddEven(reversed.Length));
        	else
        		Console.WriteLine("NO");
		}
    }
	public static string ReverseInput(string input){
		char[] inputArray = input.ToCharArray();
        Array.Reverse(inputArray);
		return new string(inputArray);
	}
	
	public static string OddEven(int length){
		if(length % 2 == 0)
			return "EVEN";
		else
			return "ODD";
	}
}
