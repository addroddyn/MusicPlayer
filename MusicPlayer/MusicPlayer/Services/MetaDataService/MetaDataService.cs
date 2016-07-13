using System;
using System.IO;

namespace MusicPlayer.Services.MetaDataService
{
    public class MetaDataService : IMetaDataService
    {
        private Uri _path;

        public void SongTagLib(Uri path)
        {
            _path = path;
            TagLib.File tagFile = TagLib.File.Create(_path.ToString());
            string _artist = tagFile.Tag.FirstArtist;
            string _songName = tagFile.Tag.Title;
            string _albumTitle = tagFile.Tag.Album;
            uint _year = tagFile.Tag.Year;

        }
    }
}
