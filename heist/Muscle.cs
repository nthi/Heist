using System;
using System.Collections.Generic;
using System.Linq;

namespace heist
{
    public class Muscle : IRobber
    {
        //just get rid of teammmember class and replace with IRobber and use the three things it requires plus the method
        public string Name { get; set; }
        public int SkillLevel { get; set; }
        public int PercentageCut { get; set; }

        public string Type { get; } = "Muscle";

        public void nameClass()
        {
            Console.WriteLine("Muscle");
        }
        public void PerformSkill(Bank bankname)
        {
            bankname.SecurityGuardScore = bankname.SecurityGuardScore - SkillLevel;
            Console.WriteLine($"{Name} confronts the guard. Decreased security by {SkillLevel} points.");
            if (bankname.SecurityGuardScore <= 0)
            {
                Console.WriteLine($"{Name} has disabled the guard!");
            }
        }
    }
}