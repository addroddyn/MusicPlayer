using System;

namespace MusicPlayer.Services.AudioService
{
    public interface IAudioService
    {
        void SetAudioFile(Uri path);
        
        void Play();

        void Stop();

        void Pause();

        bool GetIsPlaying();

        void SetIsPlaying();

        void SetVolumne(double volumne);

        double GetVolumne();
    }
}