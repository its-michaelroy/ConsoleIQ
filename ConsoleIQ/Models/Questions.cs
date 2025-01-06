using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Class represents a basic question
/// </summary>
namespace ConsoleIQ.Models
{
    //Generic question class with 3 props
    public class Question
    {
        public int Id { get; set; }
        public string Prompt { get; set; }
        public string Answer { get; set; }

        //Default constructor & Initializer
        public Question() { }

        public Question(int id, string prompt, string answer)
        {
            Id = id;
            Prompt = prompt;
            Answer = answer;
        }

        // Display the question
        public virtual void DisplayQuestion()
        {
            Console.WriteLine(Prompt);
        }

        // Method to check if the user's response is correct
        public virtual bool CheckAnswer(string userResponse)
        {
            return userResponse.Trim().Equals(Answer, StringComparison.InvariantCultureIgnoreCase);
        }
    }

}
