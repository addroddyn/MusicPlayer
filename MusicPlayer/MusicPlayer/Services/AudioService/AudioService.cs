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
        private MediaPlayer _mediaPlayer;

        public AudioService()
        {
            _mediaPlayer = new MediaPlayer();
        }

        public void  PlaySystemSound()
        {
            SystemSounds.Asterisk.Play();
        }

        public void PlayAudioFile(Uri uri)
        {
            _mediaPlayer.Open(uri);
            _mediaPlayer.Play();
        }
    }
}
