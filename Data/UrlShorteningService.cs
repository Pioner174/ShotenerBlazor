using ShotenerBlazor.Data.Interfaces;
using ShotenerBlazor.Data.Models;
using System;
using System.Linq;


namespace ShotenerBlazor.Data
{
    public class UrlShorteningService : IUrlShorteningService
    {
        public ShortUrl QuickShort(Uri url)
        {
            var shortUrl = new ShortUrl();
            shortUrl.OriginalUrl = url;
            shortUrl.DateCreated = DateTime.Now;
            shortUrl.Token = GeneratToken();
            shortUrl.Clicks = 0;
            //Если меняется хост, тут тоже надо поменять
            shortUrl.Value = new Uri($"http://localhost:5001/{shortUrl.Token}");
            return shortUrl;

        }

        private string GeneratToken()
        {
            string random = string.Empty;
            Enumerable.Range(48, 75)
                .Where(i => i < 58 || i > 64 && i < 91 || i > 96)
                .OrderBy(o => new Random().Next())
                .ToList()
                .ForEach(i => random += Convert.ToChar(i));
            return random.Substring(new Random().Next(0, random.Length - 8), 8);
        }
    }
}
