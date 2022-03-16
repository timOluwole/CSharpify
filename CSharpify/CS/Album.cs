using CSharpify.CS.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CSharpify.CS
{
    public class Album : SongCollection
    {
        public String Title { get; set; }
        public DateTime DateCreated { get; set; }
        public List<Artist> Artists { get; set; }
        public List<Genre> Genres { get; set; }
        public Boolean IsExplicit { get; set; }

        public Album(String Title, DateTime DateCreated, List<Artist> Artists, List<Song> SongList) : base(SongList)
        {
            this.Title = Title;
            this.DateCreated = DateCreated;
            this.Artists = Artists;
            BuildGenresUsingSongList();
            SetExplicitFlag();
        }

        #region private helper methods
        private void BuildGenresUsingSongList()
        {
            Genres = new List<Genre>();

            foreach (Song song in SongList)
            {
                Genre songGenre = song.Genre;
                if (!Genres.Contains(songGenre))
                {
                    Genres.Add(songGenre);
                }
            }
        }

        private void SetExplicitFlag()
        {
            IsExplicit = SongList.Any(x => x.IsExplicit);
        }
        #endregion
    }
}
