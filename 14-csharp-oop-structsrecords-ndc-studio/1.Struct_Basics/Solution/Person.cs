namespace TwoDimension
{
    public record Person(string Name, int Age);

    public record Employee(string Name, int Age, string Grade) : Person(Name, Age);
}
