using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleIQ.ManagerLogic;
using System.IO;
using System.Text.Json;
using ConsoleIQ.Models;

/// <summary>
/// Entry point of Console APP
/// </summary>
namespace ConsoleIQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, and welcome to the ConsoleIQ Quiz App!\n");
         
            // Read all topics from the JSON file & deserialize JSON content into Dict, where key is topic name & value is a list of RawQuestion objects for topic
            string jsonString = File.ReadAllText("QuestionSet.json");
            var allTopics = JsonSerializer.Deserialize<Dictionary<string, List<RawQuestion>>>(jsonString);

            // Validate topics
            if (allTopics == null || allTopics.Count == 0)
            {
                Console.WriteLine("No topics found in the question set.");
                return;
            }

            // Display available topics by grabbing list of topic names from the keys of the dictionary and displays aftre prepending the number
            Console.WriteLine("\nPlease select from the menu items below for the preloaded topic you would like to study:");
            var topicList = allTopics.Keys.ToList();
            for (int i = 0; i < topicList.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {topicList[i]}");
            }

            // Get user's topic choice & validate input
            Console.Write("\nEnter the number of your choice: ");
            int choice;
            while (!int.TryParse(Console.ReadLine(), out choice) || choice < 1 || choice > topicList.Count)
            {
                Console.Write("Invalid choice. Please enter a valid number: ");
            }

            string selectedTopic = topicList[choice - 1];


            // Create instance of QuizManager
            QuizManager quizManager = new QuizManager();

            //Right Click .Json > Change "Build action" from Blank to "Content" > Change "Copy to output directory" from Blank to "Copy if newer"
            //Steps above copy to the bin/directory path
            // Load questions from the JSON file for specificed Topic
            quizManager.LoadQuestions("QuestionSet.json", selectedTopic);

            // Start the quiz
            quizManager.StartQuiz();
        }


    }
}
