using System;
using System.Collections.Generic;

namespace heist
{

    public class TeamMember
    {
        public TeamMember (string name, int skill, double courage)
        {
            Name = name;
            SkillLevel = skill;
            CourageFactor = courage;
        }
        public string Name {get; set;}
        public int SkillLevel {get; set;}
        public double CourageFactor {get; set;}

    }


}