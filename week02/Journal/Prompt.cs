public class Prompt {

    public List<string> _prompts = new List<string>();
    //This is the list of prompts used
    
    
    public string GetRandomPrompt()
    {   
        //Generates a random prompt to use in the journal entry
        Random randomGenerator = new Random();
        int promptNumber = randomGenerator.Next(0, 4);

        _prompts.Add("Who was the most interesting person I interacted with today?");
        _prompts.Add("What was the best part of my day?");
        _prompts.Add("How did I see the hand of the Lord in my life today?");
        _prompts.Add("What was the strongest emotion I felt today?");
        _prompts.Add("If I had one thing I could do over today, what would it be?");

        string prompt = _prompts[promptNumber];
        
        return prompt;

    }
}