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
        
        public PlaylistWindowViewModel()
        {
            this.DisplayName = "Playlist";
            
            
        }

        public void ClosePlaylist()
        {
            App.Current.Windows[1].Close();
            
        }
    }
}
