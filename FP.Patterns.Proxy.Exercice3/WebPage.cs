namespace FP.Patterns.Proxy.Exercice3
{
    public class WebPage
    {
        public string Html { get; set; }

        public string Url { get; set; }

        public WebPage(string url)
        {
            Url = url;
        }
    }
}
