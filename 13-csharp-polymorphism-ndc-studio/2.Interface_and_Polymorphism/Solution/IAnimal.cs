namespace AnimalSpace
{
    public interface IAnimal
    {
        string MakeNoise();
    }

    public abstract class Animal : IAnimal
    {
        public abstract string MakeNoise();
    }
}