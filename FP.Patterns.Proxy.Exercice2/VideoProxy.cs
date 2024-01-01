namespace FP.Patterns.Proxy.Exercice2
{
    public class VideoProxy : IVideo
    {
        private int _counter;
        private bool _playingVideo;
        private readonly IVideo _video;

        public VideoProxy()
        {
            _counter = 0;
            _playingVideo = false;
            _video = new RealVideo();
        }

        public void Play()
        {
            if (_playingVideo)
            {
                Console.WriteLine("Video is already playing...");
                _counter++;
            }
            else
            {
                _video.Play();
                _playingVideo = true;
                _counter++;
            }
        }

        public void PlayCounter()
        {
            Console.WriteLine($"The video has been playing {_counter} times.");
        }
    }
}
