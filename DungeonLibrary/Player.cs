using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonLibrary
{
    public sealed class Player : Character
    {
        private int _life;
        
        public Weapon EquippedWeapon { get; set; }

        public Player(string name, int hitChance, int block, int life, int maxLife,
            Weapon equippedWeapon)
        {
            MaxLife = maxLife;
            Name = name;
            Hitchance = hitChance;
            Block = block;
            Life = life;
            EquippedWeapon = equippedWeapon;


        }

        public override string ToString()
        {
            string description = "";


            return string.Format("-=-= {0} =-=-\n" +
                "Life: {1} of {2}\nHit Chance: {3}%\n" +
                "Weapon:\n{4}\nBlock: {5}\nDescription: {6}",
                Name,
                Life,
                MaxLife,
                Hitchance,
                EquippedWeapon,
                Block,
                description);




        }
    }