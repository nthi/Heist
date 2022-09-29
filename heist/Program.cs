using System;
using System.Collections.Generic;
using System.Linq;

namespace heist
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Plan Your Heist!");
            // Console.WriteLine("What is the bank's difficulty level (1-100)?");
            // int difficulty = int.Parse(Console.ReadLine());
            // int heistLuck = new Random().Next(-10, 10);
            // int bankDifficulty = heistLuck + difficulty;

            // /* phase 6 (note these are out of order on page)
            // At the beginning of the program, prompt the user to enter the difficulty level of the bank.
            // At the end of the program, display a report showing the number of successful runs and the number of failed runs.*/

            // //update to store several team members', stop adding members when a blank name is entered, display message with number of members in team, display each team member's info.         

            // // List<TeamMember> teamMembers = new List<TeamMember>();

            // int i = 0;
            // while (i < 100)
            // {
            //     Console.WriteLine("Add team member. What is their name?");

            //     string name = Console.ReadLine();

            //     if (name == " ")
            //     {
            //         break;
            //     }
            //     else
            //     {
            //         Console.WriteLine("What is their skill level (positive integer)?");

            //         int skillLevel = int.Parse(Console.ReadLine());

            //         Console.WriteLine("What is their courage level (0.00 - 2.0)?");

            //         double courageFactor = double.Parse(Console.ReadLine()); //this is a double, fix

            //         TeamMember newMemberHere = new TeamMember(name, skillLevel, courageFactor);

            //         teamMembers.Add(newMemberHere);
            //     }
            // }

            // Console.WriteLine("How many trial runs should we simulate?");
            // int trialRuns = int.Parse(Console.ReadLine());
            
            // int successCount = 0;
            // int failCount = 0;

            // int counter = trialRuns;
            // for (int c = 0; c < counter; c++)
            // {
            //     /*update five (note these are slightly out of order on page)
            //     Run the scenario multiple times.
            //     After the user enters the team information, prompt them to enter the number of trial runs the program should perform.
            //     Loop through the difficulty / skill level calculation based on the user-entered number of trial runs. Choose a new luck value each time.
            //     */

            //     //update three: stop displaying each team member's info.
            //     //set bank difficulty level to 100.
            //     //sum skill level of team and save #
            //     //compare number with bank's difficulty level. if team level is greater than or equal to bank, display success msg, otherwise fail message.

            //     /*update four:
            //     Create a random number between -10 and 10 for the heist's luck value.
            //     Add this number to the bank's difficulty level.
            //     Before displaying the success or failure message, display a report that shows.
            //     The team's combined skill level
            //     The bank's difficulty level*/


            //     int teamSkill = teamMembers.Sum(member => member.SkillLevel);


            //     Console.WriteLine($"Your team's combined skill level is {teamSkill}.");
            //     Console.WriteLine($"The bank's difficulty level is {bankDifficulty}.");

            //     if (teamSkill >= bankDifficulty)

            //     {
            //         Console.WriteLine($"Heist successful!");
            //         successCount++;
            //     }
            //     else
            //     {
            //         Console.WriteLine($"Heist failed!");
            //         failCount++;
            //     }


            // }
            // //this was for phase 1 and 2
            // // Console.WriteLine($"Team has {teamMembers.Count} members");
            // // foreach (TeamMember member in teamMembers)
            // // {
            // //     Console.WriteLine($"Member: {member.Name}; Skill: {member.SkillLevel}; Courage: {member.CourageFactor}.");
            // // }
            //     Console.WriteLine($"Successful runs: {successCount}");
            //     Console.WriteLine($"Failed runs: {failCount}");
          


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
