using System;
using System.Collections.Generic;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        Voting votingSystem = new Voting();

        while (true)
        {
            Console.WriteLine("1. Create a new poll topic");
            Console.WriteLine("2. View existing voting topics");
            Console.WriteLine("3. Vote for the topic");
            Console.WriteLine("4. View voting results");
            Console.Write("Select the option: ");

            int choice;
            if (!int.TryParse(Console.ReadLine(), out choice))
            {
                Console.WriteLine("Please select an option from 1 to 5.");
                continue;
            }

            switch (choice)
            {
                case 1:
                    Console.Write("Enter the name of the voting topic: ");
                    string topicName = Console.ReadLine();
                    votingSystem.CreateTopic(topicName);
                    Console.WriteLine($"Voting topic \"{topicName}\" created.");
                    break;

                case 2:
                    Console.WriteLine("Existing voting topics:");
                    Console.WriteLine(votingSystem.ListTopics());
                    break;

                case 3:
                    Console.WriteLine("Choose a topic to vote on:");
                    Console.WriteLine(votingSystem.ListTopics());
                    string selectedTopic = Console.ReadLine();
                    Console.WriteLine(votingSystem.Vote(selectedTopic));
                    break;

                case 4:
                    Console.WriteLine("Voting results:");
                    Console.WriteLine(votingSystem.Results());
                    break;

                default:
                    Console.WriteLine("Please select an option from 1 to 5.");
                    break;
            }
        }
    }
}


