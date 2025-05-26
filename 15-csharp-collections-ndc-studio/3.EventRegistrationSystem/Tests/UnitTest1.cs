namespace Tests;
using Xunit;
using EventSpace;

public class UnitTest1
{
    [Fact]
    public void Test_AddParticipant()
    {
        EventSpace.Event ev = new EventSpace.Event();
        var p1 = new Participant("Alice");
        var result = ev.AddParticipant(p1, "Hackathon");
        Assert.Equal($"\nAlice has been added successfully", result);
    }

    [Fact]
    public void Test_DeleteParticipant()
    {
        EventSpace.Event ev = new EventSpace.Event();
        var p1 = new Participant("Alice");
        ev.AddParticipant(p1, "Hackathon");
        var result = ev.DeleteParticipant(p1);
        Assert.Equal($"Alice has been removed successfully", result);
    }
}
