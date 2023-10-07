using System;
using System.Collections.Generic;


public class Prompt 
{
    private Random random;
    List<string> prompt_list = new List<string>
        {
            "Who was the most interesting person I interacted with today?",
            "What was the best part of my day?",
            "How did I see the hand of the Lord in my life today?",
            "What was the strongest emotion I felt today?",
            "If I had one thing I could do over today, what would it be?"
        };

    

    public string Get_prompt()
    {
        // random int for index of prompt_list
        random = new Random();
        int index = random.Next(prompt_list.Count);
        // return string from prompt_list
        return prompt_list[index];
    }
}