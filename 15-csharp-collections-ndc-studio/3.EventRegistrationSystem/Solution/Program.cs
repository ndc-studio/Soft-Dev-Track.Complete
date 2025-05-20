namespace EventSpace
{
    public class Program
    {
        public static void Main(string[] args)
        {
            EventSpace.Event ev = new EventSpace.Event();

            Console.WriteLine("\n----------------------");
            Console.WriteLine("\n[CREATE FEW PARTICIPANT]");
            var p1 = new Participant("Alice");
            var p2 = new Participant("Bob");
            var p3 = new Participant("Jhon");
            var p4 = new Participant("Stephan");
            var p5 = new Participant("Mike");
            var p6 = new Participant("Lizzie");
            Console.WriteLine("\n----------------------");

            Console.WriteLine("\n----------------------");
            Console.WriteLine("\n[ADD PARTICIPANTS TO FEW EVENTS]");
            ev.AddParticipant(p1, "Hackathon");
            ev.AddParticipant(p2, "Hackathon");
            ev.AddParticipant(p3, "Conférence");
            ev.AddParticipant(p4, "Conférence");
            ev.AddParticipant(p5, "EscapeGame");
            ev.AddParticipant(p6, "EscapeGame");
            Console.WriteLine("\n----------------------");

            Console.WriteLine("\n----------------------");
            Console.WriteLine("\n[DISPLAY PARTICIPANT FOR ALL EVENTS]");
            ev.DisplayParticipants();
            Console.WriteLine("\n----------------------");

            Console.WriteLine("\n----------------------");
            Console.WriteLine("\n[DISPLAY PARTICIPANT BY EVENT]");
            ev.DisplayParticipantsOfEvent("Hackathon");

            Console.WriteLine("\n----------------------");
            Console.WriteLine("\n[DELETE PARTICIPANT]");
            ev.DeleteParticipant(p2);

            Console.WriteLine("\n----------------------");
            Console.WriteLine("\n[DISPLAY PARTICIPANT FOR ALL EVENTS]\nYou see \"Bob\" has been deleted");
            ev.DisplayParticipants();
            Console.WriteLine("\n----------------------");


            /* Exit system */
            Console.WriteLine("\n\n |    EXIT    |");
            Console.WriteLine("\nPress any key...");
            Console.ReadKey();
        }
    }
}