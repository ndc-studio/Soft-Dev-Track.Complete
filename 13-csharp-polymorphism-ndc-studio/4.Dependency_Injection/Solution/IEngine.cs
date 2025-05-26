namespace EngineSpace
{
    public interface IEngine
    {
        string Function();
    }

    public abstract class Engine : IEngine
    {
        public abstract string Function();
    }
}