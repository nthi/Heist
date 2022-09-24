using System;
using System.Collections.Generic;

namespace heist
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Plan Your Heist!");

            Console.WriteLine("Add team member. What is their name?");

            string newMember = Console.ReadLine();

            Console.WriteLine("What is their skill level (positive integer)?");

            string skillLevel = Console.ReadLine();

            Console.WriteLine("What is their courage level (0.00 - 2.0)?");

            string courageLevel = Console.ReadLine();

            
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
