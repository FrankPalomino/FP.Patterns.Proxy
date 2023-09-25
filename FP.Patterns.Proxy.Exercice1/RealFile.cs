namespace FP.Patterns.Proxy.Exercice1
{
    internal class RealFile : IFile
    {
        public void Read()
        {
            Console.WriteLine("Reading file");
        }

        public void Write()
        {
            Console.WriteLine("Writing file");
        }

        public void Open()
        {
            Console.WriteLine("Opening file");
        }

        public void Close()
        {
            Console.WriteLine("Closing file");
        }

    }
}
