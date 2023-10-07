using System;
using System.Collections.Generic;
using System.Text;

public class Journal
{
    public List<Entry> entries_list = new List<Entry>();

    

    public void Add_entry(DateTime date)
    {
        // user input
        Console.WriteLine($"Date: {date}");
        Prompt prompt1 = new Prompt();
        string prompt = prompt1.Get_prompt();
        Console.WriteLine($"Prompt: {prompt}");

        Console.Write("> ");
        string response = Console.ReadLine();
        // add to _entries_list
        Entry new_entry = new Entry(date, prompt, response);
        entries_list.Add(new_entry);
    }

    public void Display_all_entries()
    {
        foreach (Entry entry in entries_list)
        {
            Console.WriteLine(entry.Display_entry());
        }
    }

    public void Load_from_file(string filename)
    {
        string[] lines = System.IO.File.ReadAllLines(filename);
        foreach (string line in lines)
        {
            string[] parts = line.Split("<>");

            Entry old_entry = new Entry(DateTime.Parse(parts[0]), parts[1], parts[2]);
            entries_list.Add(old_entry);
        }
    }

    public void Save_to_file(string filename)
    {
        using (StreamWriter stf = new StreamWriter(filename))
        {
            foreach (Entry entry in entries_list)
            {
                stf.WriteLine($"{entry.Date}<>{entry.Prompt}<>{entry.Response}");
            }
        }
    }

}