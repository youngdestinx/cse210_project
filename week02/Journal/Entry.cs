using System;

public class Entry
{
    public string _prompt;
    public string _response;
    public string _date;

    public void Display()
    {
        Console.WriteLine($"Prompt: {_prompt} \nResponse: {_response}; \nDate: {_date}\n");
    }


}   
