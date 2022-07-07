using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selectionstatementsexercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var r = new Random();
            var favNumber = r.Next(1, 1000);
            Console.WriteLine("Guess a number between 1 and 1000.");
            var userInput = int.Parse(Console.ReadLine());

            if (userInput < favNumber)

                Console.WriteLine(" The Number you entered is too low.");

            else if (userInput > favNumber)

                Console.WriteLine(" The Number you entered is too High.");

            else

                Console.WriteLine(" Congratulatins you guessed right!");
        
        }
    }
}
