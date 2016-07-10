using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Media;
using Caliburn.Micro;
using Microsoft.Win32;
using MusicPlayer.Services.AudioService;

namespace MusicPlayer.Views.TestWindow
{
    public class TestWindowViewModel : Screen
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

        public TestWindowViewModel(IAudioService audioService)
        {
            _audioService = audioService;

        }

        public void makeboop()
        {
            OpenFileDialog dialog = new OpenFileDialog();

            if (dialog.ShowDialog() == true)
            {
                _audioService.PlayAudioFile(new Uri(dialog.FileName));
                
            }
            
        }
    }
}
