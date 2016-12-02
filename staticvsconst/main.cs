using System;

class Module{
	public const int third = 15;
	public static int four = 99;
	public int five = 100;
	public int Sum(int first, int second, int argThird){
		//third = argThird;
		four = argThird;
		return first + second + third + four;
	}
}

class StaticModule{
	public static int ten = 10;
	
	public static int Increment(){
		ten += 5;
		return ten;
	}
	
	public int PrintStaticMember(){
		return ten;
	}
}

class Program{
	static void Main(string[] args){
		/* Module obj = new Module();
		Console.WriteLine(obj.Sum(15, 20, 20));
		Module obj2 = new Module();
		Console.WriteLine(obj2.Sum(15,25,25));
		Console.WriteLine(Module.four); */
		
		Console.WriteLine(StaticModule.ten);
		Console.WriteLine(StaticModule.Increment());
		// Console.WriteLine(StaticModule.ten);
		
		// NonStaticModule nsm = new NonStaticModule();
		// Console.WriteLine(nsm.ten);
		// Console.WriteLine(nsm.Increment());
		// Console.WriteLine(nsm.ten);
		
		StaticModule sm = new StaticModule();
		Console.WriteLine(sm.PrintStaticMember());
		
		// NonStaticModule nsm2 = new NonStaticModule();
		// Console.WriteLine(nsm2.ten);
	}
}

class NonStaticModule{
	public int ten = 10;
	
	public int Increment(){
		ten += 5;
		return ten;
	}
}