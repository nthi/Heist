using System;
using System.Collections.Generic;

namespace heist
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Plan Your Heist!");

            //update to store several team members', stop adding members when a blank name is entered, display message with number of members in team, display each team member's info.

            List<TeamMember> teamMembers = new List<TeamMember>();

            int i = 0;
            while (i < 100)
            {
                Console.WriteLine("Add team member. What is their name?");

                string name = Console.ReadLine();

                if (name == " ")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("What is their skill level (positive integer)?");

                    int skillLevel = int.Parse(Console.ReadLine());

                    Console.WriteLine("What is their courage level (0.00 - 2.0)?");

                    double courageFactor = double.Parse(Console.ReadLine()); //this is a double, fix

                    TeamMember newMemberHere = new TeamMember(name, skillLevel, courageFactor);

                    teamMembers.Add(newMemberHere);
                }

            }

            Console.WriteLine($"Team has {teamMembers.Count} members");
            foreach (TeamMember member in teamMembers)
            {
                Console.WriteLine($"Member: {member.Name}; Skill: {member.SkillLevel}; Courage: {member.CourageFactor}.");
            }

        }
    }
}

/*
Print the message "Plan Your Heist!".
Create a way to store a single team member. A team member will have a name, a skill Level and a courage factor. The skill Level will be a positive integer and the courage factor will be a decimal between 0.0 and 2.0.
Prompt the user to enter a team member's name and save that name.
Prompt the user to enter a team member's skill level and save that skill level with the name.
Prompt the user to enter a team member's courage factor and save that courage factor with the name.
Display the team member's information.
*/
