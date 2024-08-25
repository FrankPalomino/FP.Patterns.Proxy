using FP.Patterns.Proxy.Exercice5;

IFile fileProxy = new FileProxy("1234");

fileProxy.DisplayFileInfo();
fileProxy.DownloadFile();