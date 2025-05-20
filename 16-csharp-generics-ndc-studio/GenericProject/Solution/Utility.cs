namespace GenericSpace
{ 
    public class Utility
    {
        public void Swap<T>(ref T a, ref T b)
        {
            T copyA = a;
            a = b;
            b = copyA;
        }
    }
}