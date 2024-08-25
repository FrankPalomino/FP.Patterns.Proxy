namespace FP.Patterns.Proxy.Exercice5
{
    public class RealFile : IFile
    {
        public void DisplayFileInfo()
        {
            Console.WriteLine("This is a Real File with important info");
        }

        public void DownloadFile()
        {
            Console.WriteLine("The file is going to downloading");
        }
    }
}
