namespace FP.Patterns.Proxy.Exercice1
{
    internal class FileProxy : IFile
    {
        private IFile _file;

        public FileProxy()
        {
            _file = new RealFile();
        }

        public void Read()
        {
            Console.WriteLine("Open Proxy");
            _file.Read();
        }
        public void Write()
        {
            Console.WriteLine("Open Proxy");
               _file.Write();
        }

        public void Open()
        {
            Console.WriteLine("Open Proxy");
            _file.Open();
        }

        public void Close()
        {
            Console.WriteLine("Open Proxy");
            _file.Close();
        }
    }
}
