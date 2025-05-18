using System;

public class Prompts
{
    public List<string> _prompts = new List<string>();

    public string DisplayPrompt()
    {
        DateTime currentTime = DateTime.Now;
        string date = currentTime.ToShortDateString();

        Random random = new Random();
        int index = random.Next(_prompts.Count);

        string prompt = _prompts[index];
        return prompt;

    }
    
}   