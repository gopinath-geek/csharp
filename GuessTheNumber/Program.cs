using System;

class Program
{
    static int setnum(int min, int max)
    {
        Random random = new Random();
        return random.Next(min, max);
    }
    static void Main(string[] args)
    {
        Console.WriteLine("Computer select the any one Number between 1 and 100:");
        Console.WriteLine("========================================");
        Console.WriteLine("please guess the correct number:");
        Console.WriteLine("========================================");

        int rand = setnum(1, 100);
        int count = 0, number;
        Console.WriteLine(rand);

        while (count < 3)
        {
                Console.WriteLine("it's your {0} try", count + 1);
                Console.WriteLine("guess the number:");
                number = Convert.ToInt32(Console.ReadLine());

                if (number < rand)
                {
                    Console.WriteLine("it's Low,try again");
                    Console.WriteLine("");
                    count++;
                }
                else if (number > rand)
                {
                    Console.WriteLine("it's High,try again");
                    Console.WriteLine("");
                    count++;
                }
                else if (number == rand)
                {
                    count = count + 1;
                    Console.WriteLine("you guessed correct number");
                    Console.WriteLine("you took {0} attempt(s)", count);
                    break;
                }
        } // While loop ends here
        if(count >= 3)
        {
            Console.WriteLine("Your chance is over");
        }
        Console.ReadLine();
    }
}