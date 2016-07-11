using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Windows.Media;

namespace MusicPlayer.Services.AudioService
{
    public class AudioService : IAudioService
    {
        private readonly MediaPlayer _mediaPlayer;
        private Uri _path;

        private bool _isPlaying;

        public AudioService()
        {
            _mediaPlayer = new MediaPlayer();
        }

        public void SetAudioFile(Uri path)
        {
            _path = path;
            _mediaPlayer.Open(_path);
        }

        public void Play()
        {
            _mediaPlayer.Play();
            _isPlaying = true;
        }

        public void Pause()
        {
            _mediaPlayer.Pause();
            _isPlaying = false;
        }

        public void Stop()
        {
            _mediaPlayer.Stop();
            _isPlaying = false;
        }

        public void SetVolumne(double volumne)
        {
            if(volumne > 1.0f || volumne < 0.0f)
                throw new NotSupportedException();
            _mediaPlayer.Volume = volumne;
        }

        public double GetVolumne()
        {
            return _mediaPlayer.Volume;
        }

        public bool GetIsPlaying()
        {
            return _isPlaying;
        }

        public void SetIsPlaying()
        {
            _isPlaying = true;
        }
    }
}
