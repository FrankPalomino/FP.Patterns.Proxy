namespace FP.Patterns.Proxy.Exercice4
{
    public class ProxyImage : IImage
    {
        private readonly RealImage _realImage;
        private readonly List<string> _images;

        public ProxyImage()
        {
            _realImage = new RealImage();
            _images = new List<string>();
        }

        public void Display(string name)
        {
            var result = _images.Find(x => x.Equals(name));
            if (result is null)
            {
                result = name;
                _realImage.Load(result);
                _images.Add(result);
            }

            _realImage.Display(result);
        }
    }
}
