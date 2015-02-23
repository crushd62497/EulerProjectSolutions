using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EulerProjectSolutions
{
    class Program
    {
        static void Main(string[] args)
        {

            do
            {
                string input;

                Console.WriteLine("Enter a Problem #:");
                string problem = Console.ReadLine();
                switch (Convert.ToInt32(problem))
                {
                    case 1:
                        Console.WriteLine("Enter a number:");
                        input = Console.ReadLine();
                        ProblemOne problemOne = new ProblemOne(Convert.ToInt32(input));
                        System.Console.WriteLine("The sum of the numbers from 1 to {0} divisible by 3 and 5", input);
                        System.Console.WriteLine(problemOne.getAnswer());
                        break;
                    case 2:
                        Console.WriteLine("Enter max Fibonacci sequence number:");
                        input = Console.ReadLine();
                        ProblemTwo problemTwo = new ProblemTwo(Convert.ToInt32(input));
                        System.Console.WriteLine("The sum of Fibonacchi numbers less than {0} is", input);
                        System.Console.WriteLine(problemTwo.getAnswer());
                        break;
                    case 3:
                        ProblemThree problemThree = new ProblemThree();
                        System.Console.WriteLine("The largest prime factor of the number 600851475143 is ");
                        System.Console.WriteLine(problemThree.getAnswer());
                        break;
                    case 4:
                        ProblemFour problemFour = new ProblemFour();
                        System.Console.WriteLine("The largest palindrome for multiples of two three digit numbers is ");
                        System.Console.WriteLine(problemFour.getAnswer());
                        break;
                    default:
                        Console.WriteLine("You did not enter a valid problem");
                        break;
                }
                Console.WriteLine("Hit spacebar to continue or 'Ctrl + c' to exit");
                ConsoleKeyInfo keePress;
                do
                {
                    keePress = Console.ReadKey();
                } while ((keePress.Key.ToString()) != "Spacebar");
                
                Console.Clear();
            } while (true);
        }
    }
}
