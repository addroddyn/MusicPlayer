using System;

namespace MusicPlayer.Services.AudioService
{
    public interface IAudioService
    {
        void PlaySystemSound();

        void PlayAudioFile(Uri uri);
    }
}