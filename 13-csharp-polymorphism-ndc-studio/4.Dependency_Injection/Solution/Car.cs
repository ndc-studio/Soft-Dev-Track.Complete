namespace EngineSpace
{
    public class Car
    {
        public IEngine _engine;

        public Car(IEngine engine)
        {
            _engine = engine;
        }

        public void Start()
        {
            _engine.Function();
        }
    }
}