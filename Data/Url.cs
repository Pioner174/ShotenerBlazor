using System.ComponentModel.DataAnnotations;
using System;

namespace ShotenerBlazor.Data
{
    public class Url
    {
        [Required]
        public string Value { get; set; }
    }
}
