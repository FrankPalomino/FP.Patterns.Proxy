using FP.Patterns.Proxy.Exercice1;

IFile file = new RealFile();
IFile fileProxy = new FileProxy();

fileProxy.Open();
fileProxy.Read();
fileProxy.Write();
fileProxy.Close();