using CSharpify.CS.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CSharpify.CS
{
    public class Playlist : SongCollection
    {
        public String Name { get; set; }
        public String Description { get; set; }
        public User Creator { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateLastUpdated { get; set; }

        public Playlist(String Name, String Description, User Creator, DateTime DateCreated, List<Song> SongList) : base(SongList)
        {
            this.Name = Name;
            this.Description = Description;
            this.Creator = Creator;
            this.DateCreated = DateCreated;
            this.DateLastUpdated = DateCreated;
        }

    }
}
