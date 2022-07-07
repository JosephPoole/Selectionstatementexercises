using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selectionexercise2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your favorite school subject from the following. \n English, Math, Science, History, or Art");
            var subject = Console.ReadLine();

            switch (subject)
            {
                case "english":
                    Console.WriteLine(" Your favorite subject is english!");
                    break;
                case "math":
                    Console.WriteLine("Your favorite subject is math!");
                    break;
                case "science":
                    Console.WriteLine(" Your favorite subject is science!!");
                    break;
                case "history":
                    Console.WriteLine(" Your Favorite subject is history?");
                    break;
                case "art":
                    Console.WriteLine(" Your favorite subject is art?! Mine was too!!");
                    break;}

        }
    }
}
