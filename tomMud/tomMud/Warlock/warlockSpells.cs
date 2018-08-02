using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    public class warlockSpells
    {
        public string SpellCheck(string SpellName)
        {
            String Output;

            switch (SpellName)
            {
                //Mana based spells
                case "magic missiles":

                    GlobalVar.manaCost = 1;
                    GlobalVar.damageDealt = 2;

                //Monster status check. 0 = dead. 1 = alive.
                    if (GlobalVar.monsterStatus == 0)
                        {
                            Output = "No target.";
                            return Output;
                        }
                    else if (GlobalVar.currentMP >= GlobalVar.manaCost)
                    {
                        //Deducts MP before attempt.
                        GlobalVar.currentMP = GlobalVar.currentMP - GlobalVar.manaCost;

                        //Random DiceRoll
                        Random diceRoll = new Random();
                        int randomNumber = diceRoll.Next(1, 100);
                        
                        //hitStatus.cs cruncher.
                        hitStatus hitInst = new hitStatus();
                        hitInst.hitCheck(randomNumber);

                        if (GlobalVar.playerAttack == 1)
                            {

                                Output = "You cast Magic Missiles. Dealing " + GlobalVar.damageDealt + " damage.";

                                
                                GlobalVar.monsterHP = GlobalVar.monsterHP - GlobalVar.damageDealt;
                                return Output;
                            }
                        else
                            {
                                Output = "You miss causing no damage!";
                                return Output;
                            }
                    }
                    else
                        {
                            Output = "You do not have enough mana to cast this spell.";
                            return Output;
                        }
                case "fireball":
                    GlobalVar.manaCost = 2;
                    GlobalVar.damageDealt = 4;

                //Monster status check. 0 = dead. 1 = alive.
                    if (GlobalVar.monsterStatus == 0)
                        {
                            Output = "No target.";
                            return Output;
                        }
                    else if (GlobalVar.currentMP >= GlobalVar.manaCost)
                    {
                        //Deducts MP before attempt.
                        GlobalVar.currentMP = GlobalVar.currentMP - GlobalVar.manaCost;

                        //Random DiceRoll
                        Random diceRoll = new Random();
                        int randomNumber = diceRoll.Next(1, 100);

                        //hitStatus.cs cruncher.
                        hitStatus hitInst = new hitStatus();
                        hitInst.hitCheck(randomNumber);

                        if (GlobalVar.playerAttack == 1)
                            {
                                Output = "You cast Fireball. Dealing " + GlobalVar.damageDealt + " damage.";
                                
                                GlobalVar.monsterHP = GlobalVar.monsterHP - GlobalVar.damageDealt;
                                return Output;
                            }
                        else
                            {
                                Output = "You miss causing no damage.";
                                return Output;
                            }
                    }
                    else
                        {
                            Output = "You do not have enough mana to cast this spell.";
                            return Output;
                        }

                case "death":
                    GlobalVar.manaCost = 5;
                    GlobalVar.damageDealt = warlockStats.intelligence + warlockStats.strength;

                    //Monster status check. 0 = dead. 1 = alive.
                    if (GlobalVar.monsterStatus == 0)
                        {
                            Output = "No target.";
                            return Output;
                        }
                    else if (GlobalVar.currentMP >= GlobalVar.manaCost)
                    {
                        //Deducts MP before attempt.
                        GlobalVar.currentMP = GlobalVar.currentMP - GlobalVar.manaCost;
                        
                        //Random DiceRoll
                        Random diceRoll = new Random();
                        int randomNumber = diceRoll.Next(1, 100);

                        //hitStatus.cs cruncher.
                        hitStatus hitInst = new hitStatus();
                        hitInst.hitCheck(randomNumber);

                        if (GlobalVar.playerAttack == 1)
                            {
                                Output = "You cast Death. Dealing " + GlobalVar.damageDealt + " damage.";
                                
                                GlobalVar.monsterHP = GlobalVar.monsterHP - GlobalVar.damageDealt;
                                return Output;
                            }
                        else
                            {
                                Output = "You miss causing no damage.";
                                return Output;
                            }

                    }
                    else
                    {
                        Output = "You do not have enough mana to cast this spell.";
                        return Output;
                    }
                
                // Health Based Spells
                    // Life Tap cannot miss.
                case "life tap":
                    GlobalVar.manaCost = 0;
                    GlobalVar.healthCost = 2;
                    int manaRestored = 3;
                    if (GlobalVar.currentHP > GlobalVar.healthCost)
                    {
                        Output = "You cast Life Tap.";
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
                    Output = Environment.NewLine + 
                        "Current Spells:" + Environment.NewLine + "===============" + 
                        Environment.NewLine + "Magic Missiles " + 
                        Environment.NewLine + "Fireball " +
                        Environment.NewLine + "Life Tap " +
                        Environment.NewLine + "Death ";
                    return Output;
                
                //Error.
                default:
                    Output = "That is not a valid command.";
                    return Output;


            }
        }
    }
}