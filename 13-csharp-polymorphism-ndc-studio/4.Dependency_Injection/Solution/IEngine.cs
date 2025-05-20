namespace EngineSpace
{
    public interface IEngine
    {
        void Function();
    }

    public abstract class Engine : IEngine
    {
        public abstract void Function();
    }
}