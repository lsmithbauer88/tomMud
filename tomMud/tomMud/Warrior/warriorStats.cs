using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class warriorStats
    {
        public static int strength = 10;
        public static int intelligence = 4;
        public static int dexterity = 6;
        public static int vitality = 9;
        public static int luck = 2;

        public static int warriorHP = vitality * 2 + strength;
        public static int warriorMP = intelligence + strength;

        public static int warriorSpellDamage = strength + intelligence;
        public static int warriorHitChance = dexterity * 10 + strength + luck;
        
    }
}
