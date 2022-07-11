using NAudio.Wave;
using System;

namespace GameJam
{
    public class Audio : IDisposable
    {
        private readonly WaveOutEvent outputDevice;
        private AudioFileReader audioFile;

        public Audio()
        {
            outputDevice = new WaveOutEvent();
            outputDevice.PlaybackStopped += OnPlaybackStopped;
            audioFile = new AudioFileReader(@"test.mp3");
            outputDevice.Init(audioFile);
            outputDevice.Play();
        }

        public void Dispose()
        {
            outputDevice.Stop();
            outputDevice.Dispose();
            audioFile.Dispose();
        }

        private void OnPlaybackStopped(object sender, StoppedEventArgs e)
        {
            audioFile.Position = 0;
            outputDevice.Play();
        }
    }

}


