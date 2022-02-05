using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DungeonLibrary;

namespace MonsterLibrary
{
    public class BoneDrake : Monster
    {
        public bool IsArmored { get; set; }

        public BoneDrake(string name, int life, int maxLife, int hitChance, int block, int minDamage, int maxDamage, string description, bool isArmored)
           : base(name, life, maxLife, hitChance, block, minDamage, maxDamage, description)
        {
            IsArmored = isArmored;
        }

        public BoneDrake()
        {
            MaxLife = 30;
            MaxDamage = 10;
            Name = "Bone Drake";
            Life = 30;
            Hitchance = 60;
            Block = 20;
            MinDamage = 3;
            Description = "Careful it's a drake but... just it's skeleton?";
            IsArmored = false;
        }

        public override int CalcBlock()

        {
            int calculatedBlock = Block;
            if (IsArmored)
            {
                calculatedBlock += calculatedBlock / 2;
            }

            return calculatedBlock;
        }

    }
}
