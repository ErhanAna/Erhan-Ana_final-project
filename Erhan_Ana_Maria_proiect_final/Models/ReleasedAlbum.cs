using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Erhan_Ana_Maria_proiect_final.Models
{
    public class ReleasedAlbum
    {
        public int LabelID { get; set; }
        public int AlbumID { get; set; }

        public Label? Label { get; set; }
        public Album? Album { get; set; }
    }
}
