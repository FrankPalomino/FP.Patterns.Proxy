namespace FP.Patterns.Proxy.Exercice4
{
    public class RealImage : IImage
    {
        public void Load(string name)
        {
            Console.WriteLine($"Load from Internet: {name}");
        }
        public void Display(string name)
        {
            Console.WriteLine($"Watch the beatifull image: {name}");
        }
    }
}
