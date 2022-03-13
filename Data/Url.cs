using System.ComponentModel.DataAnnotations;

namespace ShotenerBlazor.Data
{
    public class Url
    {
        [Required]
        public string Value { get; set; }
    }
}
