using System;
using System.Collections.Generic;
using System.Linq;

namespace heist
{
    public interface IRobber
    {
        //do these need to be get and set or just get?
        public string Name { get; set; }
        public int SkillLevel { get; set;}
        public int PercentageCut { get; set; }
        
        public void PerformSkill (Bank bankname);

    }
}