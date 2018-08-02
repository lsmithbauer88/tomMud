using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    public class hitStatus
    {
        public int hitCheck(int hitConc)
            {
                int Output;            
        
                int hitAttempt = 0;
                    
                            

                            if (hitConc < 100 - GlobalVar.playerHitChance)
                            {
                                hitAttempt = 0;
                                GlobalVar.playerAttack = hitAttempt;
                                Output = hitAttempt;
                                return Output;
                            }
                            else
                                hitAttempt = 1;
                                GlobalVar.playerAttack = hitAttempt;
                                Output = hitAttempt;
                                return Output;
            }
    }
}
