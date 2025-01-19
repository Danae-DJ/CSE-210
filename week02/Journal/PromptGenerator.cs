//step5: PromptGenerator.cs: the cuestions to the journal
using System;
public class PromptGenerator
{
    public List<string> _prompts = new List<string>
    {
        "Who was the most interesting person you met today?",
        "What was the best part of your day?",
        "What was the strongest emotion you felt today?",
        "How did you see the hand of the Lord in your life today?",
        "What is one thing you learned today?",
        "What is the phrase of the day?, Why?",
        
    };

    public string GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(_prompts.Count);
        return _prompts[index];
    }
}