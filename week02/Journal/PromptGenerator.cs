public class PromptGenerator
{
    public List<string> _prompts;

    public string GetRandomPrompt()
    {
        List<string> prompts = new List<string>()
        {
            "Who was the most interesting person I interacted with today?",
            "What was the best part of my day?",
            "How did I see the hand of the Lord in my life today?",
            "What was the strongest emotion I felt today?",
            "What challenged me today?",
        };
            Random random = new Random();
            int index = random.Next(prompts.Count);
            return prompts[index];
    }
}