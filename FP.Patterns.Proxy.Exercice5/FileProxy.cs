namespace FP.Patterns.Proxy.Exercice5
{
    public class FileProxy : IFile
    {
        private readonly RealFile _file;
        private readonly string _password;

        public FileProxy(string password)
        {
            _file = new RealFile();
            _password = password;
        }

        public void DisplayFileInfo()
        {
            if (_password.Equals("1234"))
            {
                _file.DisplayFileInfo();
            }
        }

        public void DownloadFile()
        {
            if (_password.Equals("1234"))
            {
                _file.DownloadFile();
            }
        }
    }
}
