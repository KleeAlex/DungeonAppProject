using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DungeonLibrary;

namespace MonsterLibrary
{
    public class Ghoul : Monster
    {

        public Ghoul(string name, int life, int maxLife, int hitChance, int block, int minDamage, int maxDamage, string description)
           : base(name, life, maxLife, hitChance, block, minDamage, maxDamage, description)
        {

        }

        public Ghoul()
        {
            MaxLife = 3;
            MaxDamage = 4;
            Name = "Ghoul";
            Life = 3;
            Hitchance = 20;
            Block = 10;
            MinDamage = 1;
            Description = "A zombie, liked you'd see in any horror movie.";
        }

        public override int CalcBlock()

        {
            int calculatedBlock = Block;


            return calculatedBlock;
        }
    }
}
