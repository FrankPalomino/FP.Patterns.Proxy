namespace FP.Patterns.Proxy.Exercice3
{
    public class ProxyServer
    {
        private readonly List<WebPage> webPages = [];

        public WebPage GetPage(string url)
        {
            WebPage page = webPages.FirstOrDefault(x => x.Url.Equals(url));

            if (page is null)
            {
                page = new WebPage(url);
                page.Html = url;
                webPages.Add(page);
            }

            return page;
        }
    }
}
