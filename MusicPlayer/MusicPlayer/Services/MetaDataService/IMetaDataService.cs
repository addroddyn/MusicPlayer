using System;

namespace MusicPlayer.Services.MetaDataService
{
    public interface IMetaDataService
    {
        void SongTagLib(Uri path);

        string getArtist();

        void setArtist(string artist);

        string getSongName();

        void setSongTitle(string song);

        string getAlbumTitle();

        void setAlbumTitle(string album);

        uint getYear();

        void setYear(uint year);
        
}
}