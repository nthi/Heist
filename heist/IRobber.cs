using System;
using System.Collections.Generic;
using System.Linq;

namespace heist
{
    public interface IRobber
    {
        public string Name { get; set; }
        public int SkillLevel { get; set;}
        public int PercentageCut { get; set; }
        
        public void PerformSkill (Bank name)
        {
            //not sure what this means. Method called PerformSkill that takes in a Bank param and doesn't return anything. Does this mean it does nothing?
        }
    }
}