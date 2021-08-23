using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exp_DCI
{
    public class Photo : Item
    {
        public int AlbumId { get; set; }

        public override int Id { get; set; }

        public override string Title { get; set; }

        public string Url { get; set; }

        public string ThumbnailUrl { get; set; }
    }
}
