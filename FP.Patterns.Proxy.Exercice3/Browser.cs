namespace FP.Patterns.Proxy.Exercice3
{
    public class Browser : IBrowser
    {
        private readonly ProxyServer _proxyServer;
        private WebPage _webPage;

        public Browser(ProxyServer proxyServer)
        {
            _proxyServer = proxyServer;
        }
        public void GetWebPage(string url)
        {
            _webPage = _proxyServer.GetPage(url);
        }

        public string ShowPage()
        {
            return _webPage.Html;
        }
    }
}
