using System;
using System.Collections.Generic;

public class PromptGenerator
{
    private List<string> _prompts = new List<string>
    {
        "Who was the most interesting person are interacted with today?",
        "What was the best part of my day?",
        "How did you see the hand of the Lord in your life today?",
        "What was the strongest emotion you felt today?",
        "If you had one thing you could do over today, what would it be?",
        "What moment today brought you the most peace or clarity?",
        "In what ways did you feel God's guidance or comfort?",
        "Did you learn anything about yourself through today's experiences?",
        "What prayer or scripture spoke to your heart today?",
        "Was there a situation where patience made a difference?",
        "What made you smile genuinely today?",
        "How did you choose faith over fear?",
        "If you could send a message of encouragement to your future self, what would it say?",

       


    };

    public string GetRandomPrompt()
    {
        Random rand = new Random();
        int index = rand.Next(_prompts.Count);
        return _prompts[index];
    }
}
