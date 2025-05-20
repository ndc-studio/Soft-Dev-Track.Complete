namespace EventSpace
{
    public class Participant
    {
        public string Name { get; set; }

        public Participant(string name)
        {
            Name = name;
            Console.WriteLine("\nParticipant {Name} has been created successfully.");
        }
    }
}