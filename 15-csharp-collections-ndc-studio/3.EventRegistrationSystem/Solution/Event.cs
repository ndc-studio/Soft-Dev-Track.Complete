using System;
using System.Collections.Generic;

namespace EventSpace
{
    public class Event
    {
        public List<(string eventName, string participantName)> Events { get; set; }

        public Event()
        {
            Events = new List<(string, string)>();
        }

        public string AddParticipant(Participant participant, string eventName)
        {
            string participantName = participant.Name;

            Events.Add((eventName, participantName));

            return $"\n{participantName} has been added successfully";
        }

        public string DeleteParticipant(Participant participant)
        {
            string participantName = participant.Name;

            for (int i = 0; i < Events.Count; i++)
            {
                if (Events[i].participantName == participantName)
                {
                    Events.RemoveAt(i);
                }
            }
            return $"{participantName} has been removed successfully";
        }

        public void DisplayParticipantsOfEvent(string name)
        {
            Console.WriteLine($"\n[ All participants for event named {name} ]");
            int i = 1;
            foreach (var events in Events)
            {
                if (events.eventName == name)
                {
                    Console.WriteLine($"\n- Participant {i}: {events.participantName}");
                    i++;
                }
            }
        }
        public void DisplayParticipants()
        {
            int i = 1;
            foreach (var events in Events)
            {
                Console.WriteLine($"\n- Participant {i}: {events.participantName} - Event: {events.eventName}");
                i++;
            }
        }
    }
}