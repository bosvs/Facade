namespace Facade
{
    class Facade
    {
        static void Main(string[] args)
        {
            
            Television tv = new Television();
            AudioSystem audio = new AudioSystem();
            MediaPlayer player = new MediaPlayer();

            
            HomeTheaterFacade homeTheater = new HomeTheaterFacade(tv, audio, player);

            
            homeTheater.WatchMovie();
            Console.WriteLine();
            homeTheater.EndMovie();

            Console.ReadLine();
        }
    }
    
    class Television
    {
        public void TurnOn() => Console.WriteLine("Television: Turning on...");
        public void TurnOff() => Console.WriteLine("Television: Turning off...");
    }

    
    class AudioSystem
    {
        public void TurnOn() => Console.WriteLine("AudioSystem: Turning on...");
        public void TurnOff() => Console.WriteLine("AudioSystem: Turning off...");
    }

    
    class MediaPlayer
    {
        public void Play() => Console.WriteLine("MediaPlayer: Playing media...");
        public void Stop() => Console.WriteLine("MediaPlayer: Stopping media...");
    }

    
    class HomeTheaterFacade
    {
        private readonly Television _television;
        private readonly AudioSystem _audioSystem;
        private readonly MediaPlayer _mediaPlayer;

        public HomeTheaterFacade(Television television, AudioSystem audioSystem, MediaPlayer mediaPlayer)
        {
            _television = television;
            _audioSystem = audioSystem;
            _mediaPlayer = mediaPlayer;
        }

        public void WatchMovie()
        {
            Console.WriteLine("Starting movie mode...");
            _television.TurnOn();
            _audioSystem.TurnOn();
            _mediaPlayer.Play();
        }

        public void EndMovie()
        {
            Console.WriteLine("Shutting down movie mode...");
            _mediaPlayer.Stop();
            _audioSystem.TurnOff();
            _television.TurnOff();
        }
    }
}