using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class warriorSpells
    {
        public string SpellCheck(string SpellName)
        {
            String Output;

            switch (SpellName)
            {
                //Mana based spells
                case "mortal strike":

                    GlobalVar.manaCost = 1;
                    GlobalVar.damageDealt = warriorStats.warriorSpellDamage - 10;

                    //Monster status check. 0 = dead. 1 = alive.
                    if (GlobalVar.monsterStatus == 0)
                        {
                            Output = "No target.";
                            return Output;
                        }
                    else if (GlobalVar.currentMP >= GlobalVar.manaCost)
                        {
                            GlobalVar.currentMP = GlobalVar.currentMP - GlobalVar.manaCost;

                            Random diceRoll = new Random();
                            int randomNumber = diceRoll.Next(1, 100);

                            hitStatus hitInst = new hitStatus();
                            hitInst.hitCheck(randomNumber);

                            if (GlobalVar.playerAttack == 1)
                                {
                                    Output = "You swing a mortal strike at the enemy dealing " + GlobalVar.damageDealt + " damage.";

                                    
                                    GlobalVar.monsterHP = GlobalVar.monsterHP - GlobalVar.damageDealt;
                                    return Output;
                                }
                            else
                                {
                                    Output = "You swing and miss! Causing no damage.";
                                    return Output;
                                }
                        }
                        else
                            {
                                Output = "You do not have enough mana to cast this spell.";
                                return Output;
                            }
                case "hamstring":
                    GlobalVar.manaCost = 2;
                    GlobalVar.damageDealt = warriorStats.warriorSpellDamage - 8;


                    //Monster status check. 0 = dead. 1 = alive.
                    if (GlobalVar.monsterStatus == 0)
                        {
                            Output = "No target.";
                            return Output;
                        }
                    else if (GlobalVar.currentMP >= GlobalVar.manaCost)
                        {
                        // Uses mana before the roll. Place it above the Monster HP reduction equation if you want the mana to not be deducted on a failed roll.
                            GlobalVar.currentMP = GlobalVar.currentMP - GlobalVar.manaCost;

                            Random diceRoll = new Random();
                            int randomNumber = diceRoll.Next(1, 100);

                            hitStatus hitInst = new hitStatus();
                            hitInst.hitCheck(randomNumber);
                            
                                if (GlobalVar.playerAttack == 1)
                                    {
                                        Output = "You hamstring your opponent dealing " + GlobalVar.damageDealt + " damage.";
                                        // Monster HP reduction equation. Place the mana reduction equation below this comment to have the mana only be deducted after a successful roll.
                                        GlobalVar.monsterHP = GlobalVar.monsterHP - GlobalVar.damageDealt;
                                        return Output;
                                    }
                                else
                                    {
                                        Output = "You swing and miss causing no damage!";
                                        return Output;
                                    }
                        }
                    else
                        {
                            Output = "You do not have enough mana to cast this spell.";
                            return Output;
                        }

                // Health Based Spells
                    //Rage cannot miss.
                case "rage":
                    
                    
                    GlobalVar.manaCost = 0;
                    GlobalVar.healthCost = 2;
                    
                    int manaRestored = 3;
                    if (GlobalVar.currentHP > GlobalVar.healthCost && GlobalVar.currentMP < warriorStats.warriorMP)
                        {
                            Output = "You are enraged and gain mana.";
                            GlobalVar.currentHP = GlobalVar.currentHP - GlobalVar.healthCost;
                            GlobalVar.currentMP = GlobalVar.currentMP + manaRestored;
                            return Output;
                        }
                    else
                        {
                            Output = "You do not have enough health to cast this spell.";
                            return Output;
                        }

                //Spell List
                case "list":
                    Output = Environment.NewLine + "Current Spells:" + 
                        Environment.NewLine + "===============" + 
                        Environment.NewLine + "Mortal Strike" + 
                        Environment.NewLine + "Hamstring" + 
                        Environment.NewLine + "Rage";
                    return Output;

                //Error.
                default:
                    Output = "That is not a valid command.";
                    return Output;


            }
        }
    }
}
