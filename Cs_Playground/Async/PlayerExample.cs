using System;

namespace Cs_Playground
{
    public class MainExampleClass
    {
        public void Main()
        {
            IPlayer player = new Mp3Player();
            player.Init("windows");

            IPlayer newPlayer = new Mp3Adapter();
            player.Init("windows");


            //We don't change it
            new Invoker(newPlayer).Play("file1");
        }
    }

    //old players
    public interface IPlayer
    {
        void Init(String os);
        void PlayFile(String fileName);
    }

    public class Mp3Player : IPlayer
    {

        private String _os;

        public void Init(String os)
        {
            _os = os;
        }

        public void PlayFile(String fileName)
        {
            Console.WriteLine("Operation System: " + _os + " , Filename: " + fileName);
        }
    }


    //new players
    public interface IAdvancedPlayer {
        void Init(String os);
        void PlayFile(String type, String fileName);
        void SetVolume(float volume);
    }

    public class VideoPlayer : IAdvancedPlayer {
        public void Init(String os) {
            
        }
        public void PlayFile(String type, String fileName) {
            Console.WriteLine("type: " + type + " filename: " + fileName);
        }
        public void SetVolume(float volume) {
            
        }
    }

    public class Mp3Adapter : IPlayer {
        private String _os;

        public void Init(String os)
        {
            _os = os;
        }

        public void PlayFile(String fileName)
        {
            new VideoPlayer().PlayFile("mp3", fileName);
        }
    }


    //We don't change it
    public class Invoker {
        
        private IPlayer player;

    public Invoker(IPlayer player)
    {
        this.player = player;
    }

    public void Play(String fileName)
    {
            player.PlayFile(fileName);
    }



        //3rd patry 
}
}