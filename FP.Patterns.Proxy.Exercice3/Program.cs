using FP.Patterns.Proxy.Exercice3;

ProxyServer euro = new();
IBrowser chrome = new Browser(euro);

chrome.GetWebPage("www.google.es");
Console.WriteLine(chrome.ShowPage());

