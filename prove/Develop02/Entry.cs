using System;

public class Entry
{
    public DateTime Date { get; set; }
    public string Prompt { get; set; }
    public string Response { get; set; }

    public Entry(DateTime date, string prompt, string response)
    {
        Date = date;
        Prompt = prompt;
        Response = response;
    }

    public string Display_entry()
    {
        string entry = $"Date: {Date} - Prompt: {Prompt}\n{Response}\n";
        return entry;
    }
}