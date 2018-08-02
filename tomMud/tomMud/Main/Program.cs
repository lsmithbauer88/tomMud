using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;



namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int classStatus = 0;
            while (classStatus == 0)
            {
            Console.WriteLine("");
            Console.WriteLine("Choose your class...");
            Console.WriteLine("");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Type classes to list available classes...");
            Console.WriteLine("");
            String classInput = Console.ReadLine().ToLower();
            
            
                if (classInput == "classes" || classInput == "class list" || classInput == "list classes" || classInput == "list class")
                    {
                        Console.WriteLine("");
                        Console.WriteLine("Classes:");
                        Console.WriteLine("==============");
                        Console.WriteLine("");
                        Console.WriteLine("Warlock");
                        Console.WriteLine("");
                        Console.WriteLine("Warrior");
                        Console.WriteLine("");
                        Console.WriteLine("==============");
                    }
                    
                        // Class 1 = Warlock
                    if (classInput == "warlock")
                    {
                        Console.WriteLine("");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("HP: " + warlockStats.warlockHP);
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine("MP: " + warlockStats.warlockMP);

                        Console.WriteLine("");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("==============");

                        Console.WriteLine("");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Strength: " + warlockStats.strength);

                        Console.WriteLine("");
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine("Intelligence: " + warlockStats.intelligence);

                        Console.WriteLine("");
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("Dexterity: " + warlockStats.dexterity);

                        Console.WriteLine("");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Vitality: " + warlockStats.vitality);

                        Console.WriteLine("");
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("Luck: " + warlockStats.luck);
                        
                        Console.WriteLine("");
                        Console.ForegroundColor = ConsoleColor.White; 
                        Console.WriteLine("==============");
                        Console.WriteLine("To confirm this class, type yes or no.");

                        String confirmWarlockClass = Console.ReadLine().ToLower();


                        if (confirmWarlockClass == "yes")
                        {
                            classStatus = 1;
                        }
                        else
                        {
                            //Do nothing... Keeping them in the loop.
                        }
                    }
                    
                    // Class 2 = Warrior
                    if (classInput == "warrior")
                    {
                        Console.WriteLine("");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("HP: " + warriorStats.warriorHP);
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine("MP: " + warriorStats.warriorMP);

                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("==============");
                        
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Strength: " + warriorStats.strength);
                        Console.WriteLine("");
                        
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine("Intelligence: " + warriorStats.intelligence);
                        Console.WriteLine("");
                        
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("Dexterity: " + warriorStats.dexterity);
                        Console.WriteLine("");
                        
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Vitality: " + warriorStats.vitality);
                        Console.WriteLine("");
                        
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("Luck: " + warriorStats.luck);
                        
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("==============");
                        
                        Console.WriteLine("To confirm this class, type yes or no.");
                        
                        String confirmWarriorClass = Console.ReadLine().ToLower();
                        
                        
                        if (confirmWarriorClass == "yes")
                        {
                            classStatus = 2;
                        }
                        else
                        {
                            //Do nothing... Keeping them in the loop.
                        }

                    }
            
            }

            if (classStatus == 1)
            {
                GlobalVar.currentHP = warlockStats.warlockHP;
                GlobalVar.currentMP = warlockStats.warlockMP;
                GlobalVar.playerMaxHP = GlobalVar.currentHP;
                GlobalVar.playerMaxMP = GlobalVar.currentMP;
                GlobalVar.playerHitChance = warlockStats.warlockHitChance;
            }
            if (classStatus == 2)
            {
                GlobalVar.currentHP = warriorStats.warriorHP;
                GlobalVar.currentMP = warriorStats.warriorMP;
                GlobalVar.playerMaxHP = GlobalVar.currentHP;
                GlobalVar.playerMaxMP = GlobalVar.currentMP;
                GlobalVar.playerHitChance = warriorStats.warriorHitChance;
            }

            Random randomEncounter = new Random();
            int randomNumber = randomEncounter.Next(0, 100);
            if (randomNumber < 80)
            {
                Console.WriteLine("You are fighting the Old Wizard!");
                GlobalVar.monsterName = "Old Wizard";

                GlobalVar.monsterHP = oldWizard.HP;
                GlobalVar.monsterMaxHP = GlobalVar.monsterHP;
                GlobalVar.monsterID = oldWizard.ID;
                GlobalVar.monsterDMG = oldWizard.intelligence / 2 + oldWizard.strength;
                
            }
            else
            {
                Console.WriteLine("You are fighting the FELGUARD!");
                Console.ForegroundColor = ConsoleColor.Red;
                GlobalVar.monsterName = "FELGUARD";
                Console.ForegroundColor = ConsoleColor.White;
                GlobalVar.monsterHP = felguard.HP;
                GlobalVar.monsterMaxHP = GlobalVar.monsterHP;
                GlobalVar.monsterID = felguard.ID;
                GlobalVar.monsterDMG = felguard.strength / felguard.intelligence + felguard.dexterity;
            }
            
            Combat attack = new Combat();

            Console.WriteLine("Type List to see the list of known spells.");
            while (GlobalVar.currentHP > 0)
            {
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("==============");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("HP:"+ GlobalVar.currentHP + "/" + GlobalVar.playerMaxHP);
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine(" MP:" + GlobalVar.currentMP + "/" + GlobalVar.playerMaxMP);
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("==============");
                Console.ForegroundColor = ConsoleColor.Red;
                if (GlobalVar.monsterStatus == 0)
                {
                    Console.WriteLine("Monster Name:-- ");
                    Console.WriteLine("Monster HP:-- ");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("==============");
                    Console.WriteLine();
                    Console.WriteLine();

                }
                else
                {
                    Console.WriteLine("Monster Name: " + GlobalVar.monsterName);
                    Console.WriteLine("Monster HP:" + GlobalVar.monsterHP + "/" + GlobalVar.monsterMaxHP);
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("==============");
                    Console.WriteLine();
                    Console.WriteLine();
                }


                String Input = Console.ReadLine().ToLower();
                if (Input == "exit" || Input == "logout" || Input == "quit")
                {
                    Environment.Exit(0);
                }
                if (classStatus == 1)
                {
                    warlockSpells spell = new warlockSpells();
                    Console.WriteLine(spell.SpellCheck(Input));
                    Console.WriteLine(attack.CombatText(Input));
                
                }
                if (classStatus == 2)
                {
                    warriorSpells spell = new warriorSpells();
                    Console.WriteLine(spell.SpellCheck(Input));
                    Console.WriteLine(attack.CombatText(Input));
                }
            }
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("You have no health. You are dead!");
            Console.ForegroundColor = ConsoleColor.White;
            Console.ReadLine();
        }
            
            
            
            

        }
    }
