using ShotenerBlazor.Data.Models;
using System;

namespace ShotenerBlazor.Data.Interfaces
{
    public interface IUrlShorteningService
    {
        ShortUrl QuickShort(Uri url);
        
    }
}
