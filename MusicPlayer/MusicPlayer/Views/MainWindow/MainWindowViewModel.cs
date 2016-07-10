using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Caliburn.Micro;
using MusicPlayer.Extensions;
using System.Windows;

namespace MusicPlayer.Views.MainWindow
{
    public class MainWindowViewModel : Screen
    {
        private string _artistName;
        private string _songName;

        public string ArtistName
        {
            get { return this._artistName; }
            set
            {
                _artistName = value;
                NotifyOfPropertyChange(() => ArtistName);
            }
        }

        public string SongName
        {
            get { return this._songName; }
            set
            {
                _songName = value;
                NotifyOfPropertyChange(() => SongName);
            }
        }


        public MainWindowViewModel()
        {
            this.DisplayName = "The best Music Player ever!";
            this.ArtistName = "Artist name goes here";
            this.SongName = "Song name goes here";
        }

        public void PlaceHolder()
        {
            MessageBox.Show("Placeholder");
        }

    }
}
