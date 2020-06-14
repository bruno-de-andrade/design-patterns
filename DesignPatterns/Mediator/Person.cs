using System;
using System.Collections.Generic;

namespace DesignPatterns.Mediator
{
    public class Person
    {
        public string Name { get; set; }

        public ChatRoom Room { get; set; }

        private readonly List<string> _chatLog = new List<string>();

        public Person(string name)
        {
            Name = name;
        }

        public void Receive(string sender, string message)
        {
            string s = $"{sender}: '{message}'";
            
            Console.WriteLine($"[{Name}'s chat session] {s}");

            _chatLog.Add(s);
        }

        public void Say(string message)
        {
            Room.Broadcast(Name, message);
        }

        public void PrivateMessage(string recipientName, string message)
        {
            Room.Message(Name, recipientName, message);
        }
    }
}
