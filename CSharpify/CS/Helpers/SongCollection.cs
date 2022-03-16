using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CSharpify.CS.Helpers
{
    public abstract class SongCollection
    {
        public List<Song> SongList { get; set; }
        public Int32 SongCount { get; set; }
        public TimeSpan TotalDuration { get; set; }

        public SongCollection(List<Song> SongList)
        {
            this.SongList = SongList;
            SetSongCount();
            BuildTotalDurationFromSongList();
        }

        #region private helper methods
        private void SetSongCount()
        {
            SongCount = SongList.Count();
        }

        private void BuildTotalDurationFromSongList()
        {
            TotalDuration = new TimeSpan();

            foreach (Song song in SongList)
            {
                TotalDuration.Add(song.Duration);
            }
        }
        #endregion
    }
}
