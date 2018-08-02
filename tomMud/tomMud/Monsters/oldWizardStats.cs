using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class oldWizard
    {
        //These need to be initialized first. Then you can calculate HP, MP, and Spell Damage...
        public static int ID = 001;
        public static int strength = 2;
        public static int intelligence = 12;
        public static int dexterity = 2;
        public static int vitality = 5;
        public static int luck = 1;
        public static int HP = strength * vitality;
        public static int MP = strength * intelligence;
        
        
        public int spellCheck(int spellName)
        {
            int Output;

            if (GlobalVar.monsterAttack == 0)
            {
                int spellDamage = 0;
                string abilityName = "Whiffs";
                GlobalVar.currentHP = GlobalVar.currentHP - spellDamage;
                Console.WriteLine("The old wiz' " + abilityName + " for " + spellDamage + " damage!");
                Output = spellDamage;
                return Output;
            }
            
            if (GlobalVar.monsterAttack == 1)
            {
                int spellDamage = oldWizard.intelligence - oldWizard.strength / 2;
                string abilityName = "Fireball";
                GlobalVar.currentHP = GlobalVar.currentHP - spellDamage;
                Console.WriteLine("The old wiz' " + abilityName + "'s your scrawny butt for" + spellDamage + " damage!");
                Output = spellDamage;
                return Output;
            }
            if (GlobalVar.monsterAttack == 2)
            {
                int spellDamage = oldWizard.intelligence / 2;
                string abilityName = "Iceball";
                GlobalVar.currentHP = GlobalVar.currentHP - spellDamage;
                Console.WriteLine("The old wiz' throws an " + abilityName + " at you for " + spellDamage + " damage! Ouch!");
                Output = spellDamage;
                return Output;
            }
            else
                Output = 0;
                return Output;
            
        }
        
    }
}
