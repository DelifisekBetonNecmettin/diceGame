using Dice;
using System;
namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {


            DiceClassRepository diceClassRepository = new DiceClassRepository();

            for (int i = 0; i < 50; i++)
            {
              var a = diceClassRepository.GetFace();


               





            }



            Console.ReadKey();


            Console.WriteLine("Hello World!");
        }
    }
}
