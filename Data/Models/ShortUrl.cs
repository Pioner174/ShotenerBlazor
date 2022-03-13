using System;
using System.Collections.Generic;

namespace ShotenerBlazor.Data.Models
{
    public class ShortUrl
    {
        public int Id { get; set; }
        public Uri OriginalUrl { get; set; }
        public Uri Value { get; set; }
        public string Token { get; set; }
        public DateTime DateCreated { get; set; }
        public int Clicks { get; set; }

    }
}
