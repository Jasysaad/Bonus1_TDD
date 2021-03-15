using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Bonus1_TDD
{
    class Program
    {
        
        static void Main(string[] args)

        {
            var myObj = new LetterGrade();
            Console.WriteLine("Welcome to Letter Grade Convertor!");
            string response;
            do
            {
                Console.Write("Enter your grade score: ");
                var grade = double.Parse(Console.ReadLine());
                Console.WriteLine("Your letter grade is: " + myObj.letterGrade(grade));
                Console.Write("Do you want to try another grade? (y/n) ");
                response = Console.ReadLine();

            }
            while (response.Equals("y", StringComparison.OrdinalIgnoreCase));

            

        }
    }
}
