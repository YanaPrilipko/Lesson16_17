using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Stack<string> people = new Stack<string>();//создание стека
        people.Push("Tom");
        people.Push("Som");
        people.Push("Ben");

        Console.WriteLine("Count: " + people.Count); 
        Console.WriteLine("Peek: " + people.Peek()); 
        string poppedValue = people.Pop();
        Console.WriteLine("Pop: " + poppedValue); 
        Console.WriteLine("Count after Pop: " + people.Count); 
    }
}

