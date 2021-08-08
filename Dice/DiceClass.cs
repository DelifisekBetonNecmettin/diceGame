using System;

namespace Dice
{
    public class DiceClass
    {
        public int Face { get; set; }
        public string Picture { get; set; }

        public DiceClass(int face,string picture)
        {
            Face = face;
            Picture = picture;


        }

    }
}
