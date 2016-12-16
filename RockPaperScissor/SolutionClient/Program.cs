using ScrapeLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolutionClient
{
    class Program
    {
        static void Main(string[] args)
        {
            int userChoice, computerChoice;
            string loop = "Y";
            string[] options = new string[] {"Rock", "Paper", "Scissor"};

            Console.WriteLine("Welcome to Rock - Paper - Scisor");

            while (loop.ToUpper() == "Y")
            {
                Console.WriteLine("Enter your choice\n\t1.Rock\n\t2.Paper\n\t3.Scisor");
                Console.Write("Your Choice : ");

                userChoice = Convert.ToInt16(Console.ReadLine());
                computerChoice = NewGame.Start();

                if (userChoice >= 4)
                {
                    Console.WriteLine("Your choice is useless, Try again");
                    continue;
                }
                else
                {
                    Console.WriteLine("You've choosen {0}", options[userChoice - 1]);
                    Console.WriteLine("My choice is {0}", options[computerChoice - 1]);
                }

              
                if (userChoice == computerChoice)
                    Console.WriteLine("It\'s a tie");
                else if ((computerChoice == 1 && userChoice == 3) ||
                            (computerChoice == 2 && userChoice == 1) ||
                            (computerChoice == 3 && userChoice == 2))
                    Console.WriteLine("Yeah! It\'s My turn. I Won");
                else
                    Console.WriteLine("Oh! God, I lost, You Won");

                Console.Write("Wanna Try again (Y/N) ?");
                loop = Console.ReadLine().ToUpper();
            }
        }
    }
}

//else if (computerChoice == 1)
//    if (userChoice == 2)
//        Console.WriteLine("Oh! God, I lost, You Won");
//    else
//        Console.WriteLine("Yeah! It\'s My turn. I Won");
//else if (computerChoice == 2)
//    if (userChoice == 3)
//        Console.WriteLine("Oh! God, I lost, You Won");
//    else
//        Console.WriteLine("Yeah! It\'s My turn. I Won");
//else if (computerChoice == 3)
//    if (userChoice == 1)
//        Console.WriteLine("Oh! God, I lost, You Won");
//    else
//        Console.WriteLine("Yeah! It\'s My turn. I Won");
//else
//    Console.WriteLine("OOPS Something went wrong");