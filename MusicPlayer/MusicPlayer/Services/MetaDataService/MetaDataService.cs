using System;
using System.IO;

namespace MusicPlayer.Services.MetaDataService
{
    public class MetaDataService : IMetaDataService
    {
        private Uri _path;
        private string _artist;
        private string _songName;
        private string _albumTitle;
        private uint _year;
        TagLib.File tagFile;
        public MetaDataService()
        {
            
        }
        public MetaDataService(Uri path)
        {
            _path = path;
            SongTagLib(_path);
            TagLib.File tagFile = TagLib.File.Create(_path.ToString());
        }
        public void SongTagLib(Uri path)
        {
            _path = path;
            string _artist = tagFile.Tag.AlbumArtists[0];
            string _songName = tagFile.Tag.Title;
            string _albumTitle = tagFile.Tag.Album;
            uint _year = tagFile.Tag.Year;
        }
        public string getArtist()
        {
            return _artist;
        }
        public void setArtist(string artist)
        {
            tagFile.Tag.AlbumArtists[0] = artist;
        }
        public string getSongName()
        {
            return _songName;
        }
        public void setSongTitle(string song)
        {
            tagFile.Tag.Title = song;
        }
        public string getAlbumTitle()
        {
            return _albumTitle;
        }
        public void setAlbumTitle(string album)
        {
            tagFile.Tag.Album = album;
        }
        public uint getYear()
        {
            return _year;
        }
        public void setYear(uint year)
        {
            tagFile.Tag.Year = year;
        }

    }
}
