using System;
using System.Collections.Generic;
using System.Linq;

namespace heist
{
    public class LockSpecialist : IRobber
    {
        //just get rid of teammmember class and replace with IRobber and use the three things it requires plus the method
        public string Name { get; set; }
        public int SkillLevel { get; set; }
        public int PercentageCut { get; set; }
        public void PerformSkill(Bank bankname)
        {
            bankname.VaultScore = bankname.VaultScore - SkillLevel;
            Console.WriteLine($"{Name} works on the bank vault lock. Decreased security by {SkillLevel} points.");
            if (bankname.AlarmScore <= 0)
            {
                Console.WriteLine($"{Name} has opened the vault!");
            }
        }
    }
}