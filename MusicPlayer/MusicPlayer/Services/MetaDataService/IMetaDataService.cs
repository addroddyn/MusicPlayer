using System;

namespace MusicPlayer.Services.MetaDataService
{
    public interface IMetaDataService
    {
        void SongTagLib(Uri path);
    }
}