using System;

class Program{
	static void Main(){
		unsafe{
			int* pointerOne;
			int valueForPointer = 45;
			pointerOne = &valueForPointer;

			Console.WriteLine(pointerOne->ToString());
		}
	}
}