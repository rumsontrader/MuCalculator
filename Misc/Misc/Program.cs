using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Misc
{
    class Program
    {
        /* static void Main(string[] args)
         {
             int correctNumber = new Random().Next(20) + 1;
             Console.WriteLine("Guess the Random number ");
             int guessedNumber;
             bool n = int.TryParse(Console.ReadLine(), out guessedNumber);

             if(guessedNumber == correctNumber)
             {
                 Console.WriteLine("You are correct!");
             }
             else
             {
                 Console.WriteLine($"Sorry the correct number was {correctNumber}");
             }
             Console.ReadLine();

         }
        static void Main(string[] args)
        {
            var myList = new List<int>() { 43, 55, 100 };
            for (int i = 0; i < myList.Count; i++)
            {
                Console.WriteLine(myList[i]);
                Console.ReadLine();
            }

            int[] numbers = new[] { 2, 3, 5, 7 };
            for(int i =0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);
            }
            Console.ReadLine();
        }*/
        static void Main(string[] args)
        {
            myMethod();
        }

        static void myMethod()
        {
            var intList = new List<int> { 24, 42, 36, 63 };
            int i = 0;
            int sum = 0;
            while (i < intList.Count)
            {
                Console.Write($"The numbers in the list are {intList[i]}");
                sum += intList[i];
                i++;
                Console.ReadLine();
            }
            Console.WriteLine($"The sum of the numbvers in the List is {sum}");
            Console.ReadLine();
        }
            
           
}
}
static void Main(string[] args)
{

}
