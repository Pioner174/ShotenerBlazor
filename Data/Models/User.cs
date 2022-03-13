﻿using System;
using System.Collections.Generic;

namespace ShotenerBlazor.Data.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public ICollection<ShortUrl> shortUrls { get; set; }
    }
}
