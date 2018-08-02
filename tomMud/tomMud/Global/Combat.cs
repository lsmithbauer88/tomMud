using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    public class Combat
    {
        public string CombatText(string monsterAction)
        {

            String Output;
            
                if (GlobalVar.monsterHP == GlobalVar.monsterMaxHP)
                {
                    Console.WriteLine("");
                    Output = "The " + GlobalVar.monsterName + " is staring at you.";
                    return Output;
                }
                else if (GlobalVar.monsterHP < GlobalVar.monsterMaxHP && GlobalVar.monsterHP > 0)
                {
                    Console.WriteLine("The monster is attacking you!");

                    Random randomAttack = new Random();
                    int randomNumber = randomAttack.Next(0, 3);
                    GlobalVar.monsterAttack = randomNumber;


                    if (GlobalVar.monsterID == 001)
                    {
                        oldWizard spell = new oldWizard();
                        spell.spellCheck(GlobalVar.monsterAttack);
                        //Output = "This needs to output the name of the attack being used by the monster!";
                        Output = "";
                        return Output;
                    }
                    if (GlobalVar.monsterID == 002)
                    {
                        felguard spell = new felguard();
                        spell.spellCheck(GlobalVar.monsterAttack);
                        //Output = "This needs to output the name of the attack being used by the monster!";
                        Output = "";
                        return Output;
                    }
                }


                if (GlobalVar.monsterHP <= 0 && GlobalVar.monsterStatus == 1)
                {
                    GlobalVar.monsterStatus = 0;
                    Output = "The " + GlobalVar.monsterName + " is dead! Congratulations!";
                    return Output;

                }
                else if (GlobalVar.monsterStatus == 0)
                {
                    Output = "Ding dong the monster is dead! Huzzah!";
                    return Output;
                }
                else
                    Output = "";
                    return Output;
            
        }
          
    }
}



