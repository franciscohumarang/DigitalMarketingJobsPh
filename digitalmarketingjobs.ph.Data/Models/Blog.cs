using System;
using System.Collections.Generic;

namespace digitalmarketingjobs.ph.Data.Models
{
    public partial class Blog
    {
        public int BlogId { get; set; }
        public byte[] ImageMain { get; set; }
        public byte[] ImageThumb { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public DateTime? PublishedDate { get; set; }
        public int? ViewsCount { get; set; }
        public bool? IsFeatured { get; set; }
        public DateTime? DateCreated { get; set; }
    }
}
