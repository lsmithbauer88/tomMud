using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class warlockStats
    {
        //These need to be initialized first. Then you can calculate HP, MP, and Spell Damage...
        public static int strength = 5;
        public static int intelligence = 10;
        public static int dexterity = 5;
        public static int vitality = 7;
        public static int luck = 4;
        //Order matters...
        public static int warlockHP = vitality * 2 + strength;
        public static int warlockMP = intelligence + vitality;

        public static int warlockSpellDamage = intelligence * 2;
        public static int warlockHitChance = dexterity * 10 + intelligence + luck;

    }
}
