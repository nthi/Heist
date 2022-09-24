

namespace heist
{
    public class TeamMember
    {
        public string Name {get; set;}
        public int SkillLevel {get; set;}
        public double CourageFactor {get; set;}

        public void NewMember(string name)
        {
            Name = name;
        }

        public void AddSkill(int skillLevel)
        {
            SkillLevel = skillLevel;
        }

        public void AddCourage(double courageFactor)
        {
            CourageFactor = courageFactor;
        }

        public List<TeamMember> TeamMembers {get; set;}

        public void AddMember (TeamMember name)
        {
            TeamMembers.Add(name);
        }
    }

}