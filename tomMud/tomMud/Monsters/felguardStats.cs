using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    

    public class felguard
        
    {
        //These need to be initialized first. Then you can calculate HP, MP, and Spell Damage...
        public static int ID = 002;
        public static int strength = 9;
        public static int intelligence = 6;
        public static int dexterity = 5;
        public static int vitality = 8;
        public static int luck = 1;
        public static int HP = strength * vitality;
        public static int MP = strength * dexterity;
        
        
        //Spells
        // 0 = Swing
        // 1 = Swooping Strike
        // 2 = Chaos Bolt

        public int spellCheck(int spellName)
        {
            int Output;

            if (GlobalVar.monsterAttack == 0)
            {
                int spellDamage = 0;
                string abilityName = "Whiffs";
                GlobalVar.currentHP = GlobalVar.currentHP - spellDamage;
                Console.WriteLine("The big ol' Felguard " + abilityName + " for " + spellDamage + " damage!");
                Output = spellDamage;
                return Output;
            }

            if (GlobalVar.monsterAttack == 1)
            {
                int spellDamage = felguard.strength / 2 - 1;
                string abilityName = "Cleave";
                GlobalVar.currentHP = GlobalVar.currentHP - spellDamage;
                Console.WriteLine("The Felguard " + abilityName + "s you in twain for " + spellDamage + "!");
                Output = spellDamage;
                return Output;
            }
            if (GlobalVar.monsterAttack == 2)
            {
                int spellDamage = felguard.intelligence / 2 + felguard.strength / 2 - 2;
                string abilityName = "Chaos Bolt";
                GlobalVar.currentHP = GlobalVar.currentHP - spellDamage;
                Console.WriteLine("The Felguard scorches you with a " + abilityName + " for " + spellDamage + " damage!");
                Output = spellDamage;
                return Output;
            }
            else
                Output = 0;
            return Output;

        }

    }
}
