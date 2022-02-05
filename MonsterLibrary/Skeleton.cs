using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DungeonLibrary;


namespace MonsterLibrary
{
    public class Skeleton : Monster
    {
        public Skeleton(string name, int life, int maxLife, int hitChance, int block, int minDamage, int maxDamage, string description)
            : base(name, life, maxLife, hitChance, block, minDamage, maxDamage, description)
        {

        }

        public Skeleton()
        {
            MaxLife = 4;
            MaxDamage = 4;
            Name = "Shambeling Bones";
            Life = 4;
            Hitchance = 15;
            Block = 10;
            MinDamage = 1;
            Description = "A moving skeleton... unnatural but it doesn't seem like much of a threat.";
        }

        public override int CalcBlock()

        {
            int calculatedBlock = Block;
           

            return calculatedBlock;
        }
    }
}
