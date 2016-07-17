using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Media;
using Caliburn.Micro;
using Microsoft.Win32;
using MusicPlayer.Services.AudioService;

namespace MusicPlayer.Views.PlaylistWindow
{
    public class PlaylistWindowViewModel : Screen
    {
        private readonly IAudioService _audioService;
        private string _text;

        public string Text
        {
            get { return this._text; }
            set
            {
                _text = value;
                NotifyOfPropertyChange(() => Text);
            }
        }

        public PlaylistWindowViewModel()
        {
            this.DisplayName = "Playlist";
        }

        public void makeboop()
        {
            
        }
    }
}
