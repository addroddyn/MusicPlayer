using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Caliburn.Micro;
using MusicPlayer.Extensions;
using System.Windows;
using MusicPlayer.Services.AudioService;
using Microsoft.Win32;

namespace MusicPlayer.Views.MainWindow
{
    public class MainWindowViewModel : Screen
    {
        private string _artistName;
        private string _songName;
        private IAudioService _audioService; 
        

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


        public MainWindowViewModel(IAudioService audioService)
        {
            this.DisplayName = "The best Music Player ever!";
            this.ArtistName = "Artist name goes here";
            this.SongName = "Song name goes here";
            _audioService = audioService;
        }

        public void PlaceHolder()
        {
            MessageBox.Show("Placeholder");
        }
        
        
        public void PlayButtonClicked()
        {
            _audioService.Play();
        }
        
        public void StopButtonClicked()
        {
            _audioService.Stop();
        }
        
        public void OpenFileClicked()
        {
            OpenFileDialog dialog = new OpenFileDialog();

            if (dialog.ShowDialog() == true)
            {
                _audioService.SetAudioFile(new Uri(dialog.FileName));
                
            }
        }

    }
}
