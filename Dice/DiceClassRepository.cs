using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dice
{
    public class DiceClassRepository
    {

        private readonly DiceClass face1 = new(1, @"C:\Users\Abdusselam\source\repos\diceGame\Dice\Dices\Dice1.jpg");
        private readonly DiceClass face2 = new(2, @"C:\Users\Abdusselam\source\repos\diceGame\Dice\Dices\Dice2.jpg");
        private readonly DiceClass face3 = new(3, @"C:\Users\Abdusselam\source\repos\diceGame\Dice\Dices\Dice3.jpg");
        private readonly DiceClass face4 = new(4, @"C:\Users\Abdusselam\source\repos\diceGame\Dice\Dices\Dice4.jpg");
        private readonly DiceClass face5 = new(5, @"C:\Users\Abdusselam\source\repos\diceGame\Dice\Dices\Dice5.jpg");
        private readonly DiceClass face6 = new(6, @"C:\Users\Abdusselam\source\repos\diceGame\Dice\Dices\Dice6.jpg");

       private DiceClass[] Check()
        {
            DiceClass[] Arr = new DiceClass[6];
            Arr[0] = face1;
            Arr[1] = face2;
            Arr[2] = face3;
            Arr[3] = face4;
            Arr[4] = face5;
            Arr[5] = face6;
            return Arr;
        }



        public int GetFace()
        {
            var array = Check();
            return array[Random()].Face;

        }

        private int Random()
        {
            return new Random().Next(0, 6);
        }
    }
}
