namespace EngineSpace
{
    public class Car
    {
        public IEngine _engine;

        public Car(IEngine engine)
        {
            _engine = engine;
        }

        public string Start()
        {
            return $"{(_engine.Function())}";
        }
    }
}