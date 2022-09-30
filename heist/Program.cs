using System;
using System.Collections.Generic;
using System.Linq;

namespace heist
{
    class Program
    {
        static void Main(string[] args)
        {
            List<IRobber> rolodex = new List<IRobber>();

            Hacker ronny = new Hacker();
            ronny.Name = "Ronny";
            ronny.SkillLevel = 77;
            ronny.PercentageCut = 20;

            Hacker mindi = new Hacker();
            mindi.Name = "Mindi";
            mindi.SkillLevel = 85;
            mindi.PercentageCut = 30;

            Muscle bean = new Muscle();
            bean.Name = "Bean";
            bean.SkillLevel = 55;
            bean.PercentageCut = 10;

            Muscle teddy = new Muscle();
            teddy.Name = "Teddy";
            teddy.SkillLevel = 80;
            teddy.PercentageCut = 30;

            LockSpecialist shades = new LockSpecialist();
            shades.Name = "Shades";
            shades.SkillLevel = 68;
            shades.PercentageCut = 15;

            LockSpecialist tammy = new LockSpecialist();
            tammy.Name = "Tammy";
            tammy.SkillLevel = 90;
            tammy.PercentageCut = 30;

            rolodex.Add(ronny);
            rolodex.Add(mindi);
            rolodex.Add(bean);
            rolodex.Add(teddy);
            rolodex.Add(shades);
            rolodex.Add(tammy);

            Console.WriteLine("Plan Your Heist!");
            Console.WriteLine($"Current contacts in rolodex: {rolodex.Count()}");

            //I need loop logic that helps me run until they are done with rolodex.
            for (int i = 1; i > 0; i++)
            {
                Console.WriteLine("Add an operative:");
                string operativeName = Console.ReadLine();
                if (operativeName != " ")
                {
                    Console.WriteLine("Type 'h' to choose Hacker, 'm' for Muscle, or 'l' for Lock Specialist");
                    string operativeChoice = Console.ReadLine();
                    Console.WriteLine("Operative's skill level (1-100):");
                    int operativeSkill = int.Parse(Console.ReadLine());
                    Console.WriteLine("Operative's percentage cut (1-100):");
                    int operativeCut = int.Parse(Console.ReadLine());

                    if (operativeChoice == "h")
                    {
                        Hacker newMember = new Hacker();
                        newMember.Name = operativeName;
                        newMember.SkillLevel = operativeSkill;
                        newMember.PercentageCut = operativeCut;
                        rolodex.Add(newMember);
                    }
                    else if (operativeChoice == "m")
                    {
                        Muscle newMember = new Muscle();
                        newMember.Name = operativeName;
                        newMember.SkillLevel = operativeSkill;
                        newMember.PercentageCut = operativeCut;
                        rolodex.Add(newMember);
                    }
                    else if (operativeChoice == "l")
                    {
                        LockSpecialist newMember = new LockSpecialist();
                        newMember.Name = operativeName;
                        newMember.SkillLevel = operativeSkill;
                        newMember.PercentageCut = operativeCut;
                        rolodex.Add(newMember);
                    }
                }
                else if (operativeName == " ")
                {
                    break;
                }
            }

            Bank FirstStreet = new Bank();
            FirstStreet.AlarmScore = new Random().Next(0, 100);
            FirstStreet.VaultScore = new Random().Next(0, 100);
            FirstStreet.SecurityGuardScore = new Random().Next(0, 100);
            FirstStreet.CashOnHand = new Random().Next(50000, 1000000);


            Console.WriteLine($"Recon:");
            Console.WriteLine($"------");

            if (FirstStreet.AlarmScore > FirstStreet.VaultScore && FirstStreet.AlarmScore > FirstStreet.SecurityGuardScore)
            {
                Console.WriteLine($"Most Secure: Alarm");
            }
            else if (FirstStreet.VaultScore > FirstStreet.AlarmScore && FirstStreet.VaultScore > FirstStreet.SecurityGuardScore)
            {
                Console.WriteLine($"Most Secure: Vault");
            }
            else if (FirstStreet.SecurityGuardScore > FirstStreet.AlarmScore && FirstStreet.SecurityGuardScore > FirstStreet.VaultScore)
            {
                Console.WriteLine($"Most Secure: Guard");
            }
            else
            {
                Console.WriteLine($"Most Secure: UNCERTAIN.");
            }

            Console.WriteLine($"Team Report:");
            Console.WriteLine($"------------");
            foreach (IRobber member in rolodex)
            {
                Console.WriteLine("...............");
                Console.WriteLine($"{member.Name}");
                member.nameClass();
                Console.WriteLine($"Skill Level: {member.SkillLevel}");
                Console.WriteLine($"Cut: {member.PercentageCut}%");
                Console.WriteLine("...............");
                Console.WriteLine();

            }





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
