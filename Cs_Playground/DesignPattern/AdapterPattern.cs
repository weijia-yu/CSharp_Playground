using System;

// Before we were using 
namespace Cs_Playground.DesignPattern {
    public interface AudioPlayer {
        void Play(String audioType, String fileName);
    }

    public interface AdvancedPlayer {
        void PlayMp4(String fileName);
        void PlayAvi(String fileName);
    }

    public class Mp4Player : AdvancedPlayer {
        public  void PlayMp4(String fileName)
        {
            Console.WriteLine("play mp4");
        }
        public  void PlayAvi(String fileName) {
        }
    }

    public class AviPlayer : AdvancedPlayer
    {
        public void PlayMp4(String fileName)
        {
            
        }
        public void PlayAvi(String fileName)
        {
            Console.WriteLine("play avi");
        }
    }

 
    public class V1Player : AudioPlayer {
        public void Play(String audioType, String fileName) {
            Console.WriteLine(audioType + " " + fileName);
        }
    }

    public class V2Player : AudioPlayer {
        private AdvancedPlayer _advancedPlayer;
        public void Play(String audioType, String fileName) {
            _advancedPlayer = new AviPlayer();
            _advancedPlayer.PlayAvi(fileName);
        }
    }

}
