namespace AnimalSpace
{
    public interface IAnimal
    {
        void MakeNoise();
    }

    public abstract class Animal : IAnimal
    {
        public abstract void MakeNoise();
    }
}