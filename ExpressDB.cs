using ShotenerBlazor.Data.Models;
using System.Collections.Generic;

namespace ShotenerBlazor
{
    public class ExpressDB
    {
        public ExpressDB()
        {
            ShortUrls = new List<ShortUrl>();
        }
        public List<ShortUrl> ShortUrls { get; set; }

    }
}
