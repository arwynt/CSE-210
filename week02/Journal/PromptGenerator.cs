using System;
using System.Collections.Generic;

public class PromptGenerator
{
    public List<string> _prompts = new List<string>
    {
        "What about today made you smile?",
        "What random act of kindness did you see or experience today?",
        "What do I need to do to feel at peace?",
        "What question are you grappling with?",
        "How are your current circumstances affecting your mental health?"
    };

    public string GetRandomPrompt()
    {
        Random random = new Random();
        
        int index = random.Next(_prompts.Count);

        return _prompts[index];
    }
}