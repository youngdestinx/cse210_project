using System;
using System.IO;


public class Journal
{
    public List<Entry> _entries = new List<Entry>();

    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }


    public void Display()
    {
        foreach(Entry entry in _entries)
        {
            entry.Display();
        }
    }

    public void SaveToFile(string file)
    {
        List<string> entary = new List<string>();

        foreach (Entry entry in _entries)
        {
            string part = entry._prompt;
            string part2 = entry._response;
            string part3 = entry._date;

            entary.Add(part + "#" + part2 + "#" + part3);
        }

        File.WriteAllLines(file, entary);
        Console.WriteLine("Journal saved successfully as" + ":" + " " + file);

    }
    
    public void LoadFromFile(string file)
    {
        string [] loadedEntry = File.ReadAllLines(file);
        List<string> entary = new List<string>();

        Console.WriteLine("Make your changes? ");
        string edit = Console.ReadLine();

        foreach (string line in loadedEntry)
        {
            string [] parts = line.Split("#");

            string prompt = parts[0];
            string response = parts[1];
            string date = parts[2];

            entary.Add(prompt + "#" + edit + "#" + date);

            File.WriteAllLines(file, entary);
            Console.WriteLine("Journal loaded successfully");
         
        }
        
    }
    
}   
