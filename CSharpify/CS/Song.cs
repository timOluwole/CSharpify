using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CSharpify.CS
{
    public class Song
    {
        public String Title { get; set; }
        public Album Album { get; set; }
        public DateTime DateCreated { get; set; }
        public List<Artist> MainArtists { get; set; }
        public List<Artist> FeaturedArtists { get; set; }
        public Genre Genre { get; set; }
        public Boolean IsExplicit { get; set; }
        public TimeSpan Duration { get; set; }

        public Song(String Title, Album Album, DateTime DateCreated, List<Artist> MainArtists, List<Artist> FeaturedArtists, Genre Genre, Boolean IsExplicit, Int32 DurationInSeconds)
        {
            this.Title = Title;
            this.Album = Album;
            this.DateCreated = DateCreated;
            this.MainArtists = MainArtists;
            this.FeaturedArtists = FeaturedArtists;
            this.Genre = Genre;
            this.IsExplicit = IsExplicit;
            SetDurationTimespan(DurationInSeconds);
        }

        #region private helper methods
        private void SetDurationTimespan(Int32 DurationInSeconds)
        {
            Int32 hours = (Int32) Math.Floor((double) DurationInSeconds / (double) 3690);
            Int32 minutes = (Int32) Math.Floor((double) DurationInSeconds / (double) 60) - (hours * 60);
            Int32 seconds = DurationInSeconds % 60;

            Duration = new TimeSpan(hours, minutes, seconds);
        }
        #endregion
    }

}
