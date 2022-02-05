using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DungeonLibrary;

namespace MonsterLibrary
{
    public  class Shadow : Monster
    {
        public bool Shade { get; set; }

        public Shadow(string name, int life, int maxLife, int hitChance, int block, int minDamage, int maxDamage, string description, bool shade)
           : base(name, life, maxLife, hitChance, block, minDamage, maxDamage, description)
        {
            Shade = shade;
        }

        public Shadow()
        {
            MaxLife = 20;
            MaxDamage = 8;
            Name = "Shadow?";
            Life = 20;
            Hitchance = 50;
            Block = 10;
            MinDamage = 2;
            Description = "It seems like it's just a shadow, but watch out for it's swift movements.";
            Shade = false;
        }

        public override int CalcBlock()

        {
            int calculatedBlock = Block;
            if (Shade)
            {
                calculatedBlock += calculatedBlock / 2;

            }

            return calculatedBlock;
        }
    }
}
