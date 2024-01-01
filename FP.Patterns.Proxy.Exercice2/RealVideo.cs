namespace FP.Patterns.Proxy.Exercice2
{
    public class RealVideo : IVideo
    {
        public void Play()
        {
            Console.WriteLine("Playing video...");
        }
    }
}
