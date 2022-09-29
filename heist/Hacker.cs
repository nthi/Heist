using System;
using System.Collections.Generic;
using System.Linq;

namespace heist
{
    public class Hacker : IRobber
    {
        //just get rid of teammmember class and replace with IRobber and use the three things it requires plus the method
        public string Name { get; set; }
        public int SkillLevel { get; set; }
        public int PercentageCut { get; set; }
        public void PerformSkill(Bank bankname)
        {
            bankname.AlarmScore = bankname.AlarmScore - SkillLevel;
            Console.WriteLine($"{Name} is hacking the alarm system. Decreased security by {SkillLevel} points.");
            if (bankname.AlarmScore <= 0)
            {
                Console.WriteLine($"{Name} has disabled the alarm system!");
            }
        }
    }
}